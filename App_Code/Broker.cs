using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using Domain;
using MySql.Data.MySqlClient;

namespace Session
{
    public class Broker
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        private void ConnectTo()
        {
            connection = new MySqlConnection("server=localhost;user id=root;password=root;database=mydb;persistsecurityinfo=True");
            command = connection.CreateCommand();
        }

        public Broker()
        {
            ConnectTo();
        }

        public void Insert(Human human)
        {
            try
            {
                command.CommandText = "INSERT INTO tname (Name) VALUES('" + human.Name + "')";
                command.CommandType = CommandType.Text;
                connection.Open();

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }

        public List<Human> Fill()
        {
            List<Human> humansList = new List<Human>();

            try
            {
                command.CommandText = "SELECT * FROM tname";

                command.CommandType = CommandType.Text;
                connection.Open();

                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Human human = new Human();

                    human.id = Convert.ToInt32(reader["id"].ToString());
                    human.Name = reader["name"].ToString();

                    humansList.Add(human);
                }
                return humansList;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                if (connection != null)
                {
                    connection.Close();
                }
            }
        }
    }
}
