using CaffeeData.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaffeeData
{
    public class UserRepository
    {
        public List<User> GetAllUsers()
        {
            
            List<string> lines = new List<string>();

            List<User> users = new List<User>();

            string filePath = GetPath() + "Users.txt";

            lines = File.ReadAllLines(filePath).ToList();

            foreach(string line in lines)
            {
                string[] items = line.Split(',');

                User u = new User(items[0], items[1], Convert.ToBoolean(items[2].ToLower()));

                users.Add(u);
            }

            return users;
        }

        public void InsertNewUser(User u)
        {
            //Banov flie path
            //string filePath = @"C:\Users\Bane\Desktop\ProjekatSi\si2021-projekat-si2021-14-caffee\CaffeeData\Users.txt";

            //Pajov file path
            string filePath = GetPath() + "Users.txt"; 

            List<User> users = GetAllUsers();

            users.Add(u);

            List<string> outContents = new List<string>();

            foreach (User user in users)
            {
                outContents.Add(user.ToString());
            }

            File.WriteAllText(filePath, "");

            File.WriteAllLines(filePath, outContents);
        }

        public void InsertNewOwner(Owner owner)
        {

            //Banov flie path
            //string filePath = @"C:\Users\Bane\Desktop\ProjekatSi\si2021-projekat-si2021-14-caffee\CaffeeData\Users.txt";

            //Pajov file path
            List<User> users = new List<User>();

            string filePath = GetPath() + "Users.txt";

            if (!CheckIfExists(filePath))
            {
                using (FileStream fs = File.Create(filePath)) { }
            }
            else if (!isEmpty(filePath))
            {
                users = GetAllUsers();
            }

                users.Add(owner);

                List<string> outContents = new List<string>();

                foreach (User user in users)
                {
                    outContents.Add(user.ToString());
                }

                File.WriteAllText(filePath, "");

                File.WriteAllLines(filePath, outContents);
            
        }

        public static string GetPath()
        {
            
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(roamingDirectory, "Astali\\");
            if (!File.Exists(filePath))
                Directory.CreateDirectory(filePath);

            return filePath;
        }

        private bool CheckIfExists(string filePath)
        {
            if (File.Exists(filePath))
            {
                //if (new FileInfo(filePath).Length != 0)
                //{
                //    return false;
                //}
                return true;
            }
            else return false;

            //if (new FileInfo(filePath).Length != 0)
            //    return false;
            //return true;
        }

        private bool isEmpty(string filePath)
        {
            if (new FileInfo(filePath).Length == 0)
            {
                return true;
            }
            return false;
        }

    }
}
