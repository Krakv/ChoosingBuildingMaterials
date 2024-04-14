using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Mysqlx.Expect.Open.Types;

namespace ChoosingBuildingMaterials
{
    internal class SQLQuery
    {
        static public string password = "";
        static public string user = "user";
        static public string lastSelect = "";
        public static void Add(string table, string[] parameters)
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            string values = "(";
            foreach (var parameter in parameters)
            {
                values += $"'{parameter}', ";
            }
            values = values.Remove(values.Length - 2, 2) + ")";
            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand($"INSERT INTO {table} VALUES {values}", con);

                cmd.ExecuteNonQuery();
            }
        }

        public static void UPDATE(string table, string parameters, string condition)
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand($"UPDATE {table} SET {parameters} WHERE 1 = 1 {condition}", con);

                cmd.ExecuteNonQuery();
            }
        }

        public static List<string[]> ReadManufacturers(string condition = "")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM manufacturers " +
                    $"WHERE 1 = 1 {condition} ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string[] value  = new string[4];
                        value[0] = dr["manufacturer_number"].ToString();
                        value[1] = dr["name"].ToString();
                        value[2] = dr["site"].ToString();
                        value[3] = dr["contact_info"].ToString();
                        result.Add(value);
                    }
                }
            }
            return result;
        }

        public static string SimpleReadQuery(string query, string column)
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            string result = "";

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(query, con);

                using (var dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        result = dr[column].ToString();
                    }
                }
            }
            return result;
        }

        public static string SimpleExecuteQuery(string query)
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            string result = "";

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(query, con);

                cmd.ExecuteNonQuery();
            }
            return result;
        }

        public static List<string[]> ReadRegions()
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    "FROM regions ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string[] value = new string[2];
                        value[0] = dr["number"].ToString();
                        value[1] = dr["name"].ToString();
                        result.Add(value);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadMaterials(string condition = "", int offset = 0, int limit = 20)
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM materials {condition} " +
                    $"LIMIT {limit} OFFSET {offset} ", con);

                lastSelect = @"SELECT * " +
                    $"FROM materials {condition} ";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int index = 0;
                        string[] values = new string[10];
                        values[index++] = dr["material_number"].ToString();
                        values[index++] = dr["name"].ToString();
                        values[index++] = dr["application_field"].ToString();
                        values[index++] = dr["packaging"].ToString();
                        values[index++] = dr["technical_characteristics"].ToString();
                        values[index++] = dr["instruction_for_use"].ToString();
                        values[index++] = dr["precautions"].ToString();
                        values[index++] = dr["storage_and_transportation"].ToString();
                        values[index++] = dr["certificates"].ToString();
                        values[index] = dr["manufacturer_number"].ToString();
                        //values[index] = SQLQuery.SimpleReadQuery($"SELECT manufacturer_number, name FROM manufacturers WHERE manufacturer_number = '{values[index - 1]}'", "name");
                        result.Add(values);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadMaterialsCatalog( string subcatalog, string condition = "", int offset = 0, int limit = 20, string order = "materials.name")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT materials.material_number, materials.name, application_field, packaging, technical_characteristics, instruction_for_use, " +
                    $"precautions,  storage_and_transportation, certificates, materials.manufacturer_number, COUNT(stores.store_number),  SUM(count), MIN(cost) " +
                    $"FROM materials_catalog, materials, materials_available, stores " +
                    $"WHERE materials.material_number = materials_catalog.material_number " +
                    $"AND materials.material_number = materials_available.material_number " +
                    $"AND stores.store_number = materials_available.store_number " +
                    $"AND subcatalog_id = {subcatalog} {condition} " +
                    $"GROUP BY materials.material_number " +
                    $"ORDER BY {order} " +
                    $"LIMIT {limit} OFFSET {offset} ", con);

                lastSelect = @"SELECT materials.material_number, materials.name, application_field, packaging, technical_characteristics, instruction_for_use, " +
                    $"precautions,  storage_and_transportation, certificates, materials.manufacturer_number, COUNT(stores.store_number),  SUM(count), MIN(cost) " +
                    $"FROM materials_catalog, materials, materials_available, stores " +
                    $"WHERE materials.material_number = materials_catalog.material_number " +
                    $"AND materials.material_number = materials_available.material_number " +
                    $"AND stores.store_number = materials_available.store_number " +
                    $"AND subcatalog_id = {subcatalog} {condition} " +
                    $"GROUP BY materials.material_number " +
                    $"ORDER BY {order} ";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int index = 0;
                        string[] values = new string[13];
                        values[index++] = dr["material_number"].ToString();
                        values[index++] = dr["name"].ToString();
                        values[index++] = dr["application_field"].ToString();
                        values[index++] = dr["packaging"].ToString();
                        values[index++] = dr["technical_characteristics"].ToString();
                        values[index++] = dr["instruction_for_use"].ToString();
                        values[index++] = dr["precautions"].ToString();
                        values[index++] = dr["storage_and_transportation"].ToString();
                        values[index++] = dr["certificates"].ToString();
                        values[index++] = dr["manufacturer_number"].ToString();
                        values[index++] = dr["COUNT(stores.store_number)"].ToString();
                        values[index++] = dr["SUM(count)"].ToString();
                        values[index++] = dr["MIN(cost)"].ToString();
                        //values[index] = SQLQuery.SimpleReadQuery($"SELECT manufacturer_number, name FROM manufacturers WHERE manufacturer_number = '{values[index - 1]}'", "name");
                        result.Add(values);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadMaterialsCatalogWithCheckBoxes(string subcatalog, string condition = "", int offset = 0, int limit = 20, string tables = "", string order = "materials.name")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT materials.material_number, materials.name, application_field, packaging, technical_characteristics, instruction_for_use, " +
                    $"precautions,  storage_and_transportation, certificates, materials.manufacturer_number, COUNT(stores.store_number),  SUM(count), MIN(cost) " +
                    $"FROM materials_catalog, materials, materials_available, stores, manufacturers {tables}  " +
                    $"WHERE materials.material_number = materials_catalog.material_number " +
                    $"AND materials.material_number = materials_available.material_number " +
                    $"AND stores.store_number = materials_available.store_number " +
                    $"AND subcatalog_id = {subcatalog} " +
                    $"AND manufacturers.manufacturer_number = materials.manufacturer_number {condition} " +
                    $"GROUP BY materials.material_number " +
                    $"ORDER BY {order} " +
                    $"LIMIT {limit} OFFSET {offset} ", con);

                lastSelect = @"SELECT materials.material_number, materials.name, application_field, packaging, technical_characteristics, instruction_for_use, " +
                    $"precautions,  storage_and_transportation, certificates, materials.manufacturer_number, COUNT(stores.store_number),  SUM(count), MIN(cost) " +
                    $"FROM materials_catalog, materials, materials_available, stores, manufacturers {tables}  " +
                    $"WHERE materials.material_number = materials_catalog.material_number " +
                    $"AND materials.material_number = materials_available.material_number " +
                    $"AND stores.store_number = materials_available.store_number " +
                    $"AND subcatalog_id = {subcatalog} " +
                    $"AND manufacturers.manufacturer_number = materials.manufacturer_number {condition} " +
                    $"GROUP BY materials.material_number " +
                    $"ORDER BY {order} ";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int index = 0;
                        string[] values = new string[13];
                        values[index++] = dr["material_number"].ToString();
                        values[index++] = dr["name"].ToString();
                        values[index++] = dr["application_field"].ToString();
                        values[index++] = dr["packaging"].ToString();
                        values[index++] = dr["technical_characteristics"].ToString();
                        values[index++] = dr["instruction_for_use"].ToString();
                        values[index++] = dr["precautions"].ToString();
                        values[index++] = dr["storage_and_transportation"].ToString();
                        values[index++] = dr["certificates"].ToString();
                        values[index++] = dr["manufacturer_number"].ToString();
                        values[index++] = dr["COUNT(stores.store_number)"].ToString();
                        values[index++] = dr["SUM(count)"].ToString();
                        values[index++] = dr["MIN(cost)"].ToString();
                        //values[index] = SQLQuery.SimpleReadQuery($"SELECT manufacturer_number, name FROM manufacturers WHERE manufacturer_number = '{values[index - 1]}'", "name");
                        result.Add(values);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadMaterialsAvailableStores(string condition = "")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM materials_available, stores " +
                    $"WHERE materials_available.store_number = stores.store_number {condition} ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string[] value = new string[7];
                        value[0] = dr["material_available_number"].ToString();
                        value[1] = dr["material_number"].ToString();
                        value[2] = dr["store_number"].ToString();
                        value[3] = dr["name"].ToString();
                        value[4] = dr["real_address"].ToString();
                        value[5] = dr["count"].ToString();
                        value[6] = dr["cost"].ToString();
                        result.Add(value);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadMaterialsAvailable(string condition = "", int offset = 0, int limit = 20, string order = "materials.name")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT materials.material_number, materials.name, application_field, packaging, technical_characteristics, instruction_for_use, " +
                    $"precautions,  storage_and_transportation, certificates, materials.manufacturer_number, COUNT(stores.store_number),  SUM(count), MIN(cost) " +
                    $"FROM materials_available, materials, stores " +
                    $"WHERE materials_available.material_number = materials.material_number " +
                    $"AND stores.store_number = materials_available.store_number {condition} " +
                    $"GROUP BY materials.material_number " +
                    $"ORDER BY {order} " +
                    $"LIMIT {limit} OFFSET {offset} ", con);

                lastSelect = @"SELECT materials.material_number, materials.name, application_field, packaging, technical_characteristics, instruction_for_use, " +
                    $"precautions,  storage_and_transportation, certificates, materials.manufacturer_number, COUNT(stores.store_number),  SUM(count), MIN(cost) " +
                    $"FROM materials_available, materials, stores " +
                    $"WHERE materials_available.material_number = materials.material_number " +
                    $"AND stores.store_number = materials_available.store_number {condition} " +
                    $"GROUP BY materials.material_number " +
                    $"ORDER BY {order} ";

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int index = 0;
                        string[] values = new string[13];
                        values[index++] = dr["material_number"].ToString();
                        values[index++] = dr["name"].ToString();
                        values[index++] = dr["application_field"].ToString();
                        values[index++] = dr["packaging"].ToString();
                        values[index++] = dr["technical_characteristics"].ToString();
                        values[index++] = dr["instruction_for_use"].ToString();
                        values[index++] = dr["precautions"].ToString();
                        values[index++] = dr["storage_and_transportation"].ToString();
                        values[index++] = dr["certificates"].ToString();
                        values[index++] = dr["manufacturer_number"].ToString();
                        values[index++] = dr["COUNT(stores.store_number)"].ToString();
                        values[index++] = dr["SUM(count)"].ToString();
                        values[index++] = dr["MIN(cost)"].ToString();
                        //values[index] = SQLQuery.SimpleReadQuery($"SELECT manufacturer_number, name FROM manufacturers WHERE manufacturer_number = '{values[index - 1]}'", "name");
                        result.Add(values);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadMaterialsAvailableWithCheckBoxes(string condition = "", int offset = 0, int limit = 20, string tables = "", string order = "materials.name")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();

                lastSelect = @"SELECT materials.material_number, materials.name, application_field, packaging, technical_characteristics, instruction_for_use, " +
                    $"precautions,  storage_and_transportation, certificates, materials.manufacturer_number, COUNT(stores.store_number),  SUM(count), MIN(cost) " +
                    $"FROM materials, materials_available, stores {tables} " +
                    $"WHERE materials.material_number = materials_available.material_number " +
                    $"AND stores.store_number = materials_available.store_number {condition} " +
                    $"GROUP BY materials.material_number " +
                    $"ORDER BY {order} ";

                var cmd = new MySqlCommand(lastSelect  + $" LIMIT {limit} OFFSET {offset} ", con);


                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int index = 0;
                        string[] values = new string[13];
                        values[index++] = dr["material_number"].ToString();
                        values[index++] = dr["name"].ToString();
                        values[index++] = dr["application_field"].ToString();
                        values[index++] = dr["packaging"].ToString();
                        values[index++] = dr["technical_characteristics"].ToString();
                        values[index++] = dr["instruction_for_use"].ToString();
                        values[index++] = dr["precautions"].ToString();
                        values[index++] = dr["storage_and_transportation"].ToString();
                        values[index++] = dr["certificates"].ToString();
                        values[index++] = dr["manufacturer_number"].ToString();
                        values[index++] = dr["COUNT(stores.store_number)"].ToString();
                        values[index++] = dr["SUM(count)"].ToString();
                        values[index++] = dr["MIN(cost)"].ToString();
                        result.Add(values);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadStores(string condition = "")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM stores {condition} ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string[] value = new string[8];
                        value[0] = dr["store_number"].ToString();
                        value[1] = dr["name"].ToString();
                        value[2] = dr["legal_address"].ToString();
                        value[3] = dr["real_address"].ToString();
                        value[4] = dr["director_name"].ToString();
                        value[5] = dr["director_surname"].ToString();
                        value[6] = dr["director_father"].ToString();
                        value[7] = dr["phone_number"].ToString();
                        result.Add(value);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadTags(string condition = "", string tables = "")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM tags {tables} " +
                    $"WHERE 1 = 1 {condition} " +
                    $"GROUP BY tags.tag_id ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string[] value = new string[2];
                        value[0] = dr["tag_id"].ToString();
                        value[1] = dr["name"].ToString();
                        result.Add(value);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadCatalogs(string condition = "", string tables = "")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM catalogs {tables} " +
                    $"WHERE 1 = 1 {condition} ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string[] value = new string[2];
                        value[0] = dr["id"].ToString();
                        value[1] = dr["name"].ToString();
                        result.Add(value);
                    }
                }
            }
            return result;
        }

        public static List<string[]> ReadSubcatalogs(string condition = "", string tables = "")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(@"SELECT * " +
                    $"FROM subcatalogs {tables} " +
                    $"WHERE 1 = 1 {condition} ", con);

                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        string[] value = new string[3];
                        value[0] = dr["id"].ToString();
                        value[1] = dr["catalog_id"].ToString();
                        value[2] = dr["name"].ToString();
                        result.Add(value);
                    }
                }
            }
            return result;
        }

        public static void OutFile(string path = "")
        {
            var cs = $"server=localhost;user={user};database=is_building_materials;password={password};CharSet=utf8;";
            List<string[]> result = new List<string[]>();

            using (var con = new MySqlConnection(cs))
            {
                con.Open();
                var cmd = new MySqlCommand(lastSelect + $" INTO OUTFILE '{path}' " +
                    $"FIELDS TERMINATED BY ';' " +
                    $@"LINES TERMINATED BY '\n' ", con);

                cmd.ExecuteNonQuery();
            }
        }
    }
}
