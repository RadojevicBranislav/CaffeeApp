using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Caffee
{
    public static class Constants
    {
        
        

        public static string GetPath()
        {
            var roamingDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = Path.Combine(roamingDirectory, "Astali\\");
            if(!File.Exists(filePath))
                Directory.CreateDirectory(filePath);
            
                return filePath;    
        }
    }
}
