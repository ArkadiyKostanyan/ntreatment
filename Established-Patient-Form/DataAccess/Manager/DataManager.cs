using DataAccess.Models;
using DataAccess.Serializer;
using System;
using System.IO;

namespace DataAccess.Manager
{
    public class DataManager
    {
        private const string fileName = "model.json";

        private const string fileName2 = "modelPID.json";

        public TemplateModel Get()
        {
            if (!File.Exists(FilePath()))
            {
                return new TemplateModel();
            }

            var dataFromFile = File.ReadAllText(FilePath());
            TemplateModel data = DataSerializer.Deserialize<TemplateModel>(dataFromFile);
            data.Init();
            return data;
        }

        public void Save(TemplateModel model)
        {
            string json = DataSerializer.Serialize(model);
            if (!File.Exists(FilePath()))
            {
                File.Create(FilePath()).Close();
            }
            File.WriteAllText(FilePath(), json);
        }

        public void SavePID(object model)
        {
            string json = DataSerializer.Serialize(model);
            if (!File.Exists(FilePath(true)))
            {
                File.Create(FilePath(true)).Close();
            }
            File.WriteAllText(FilePath(true), json);
        }

        private string FilePath(bool isPID = false)
        {
            if(isPID)
            {
                return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName2);
            }
            return Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);
        }
    }
}
