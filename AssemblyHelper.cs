using System;
using System.IO;
using System.Reflection;

namespace EmbeddedResourceExtractor
{
    public class AssemblyHelper
    {
        public string FilePath { get; private set; }
        public bool IsValid { get { return assembly != null; } }
        public string ErrorDescription { get; private set; }

        private readonly Assembly assembly;

        public AssemblyHelper(string filePath)
        {
            FilePath = filePath;

            try
            {
                assembly = Assembly.LoadFile(filePath);
            }
            catch(Exception ex)
            {
                ErrorDescription = ex.Message;
            }
        }

        public string[] ListResourceNames()
        {
            if (!IsValid)
                return new string[0];

            return assembly.GetManifestResourceNames();
        }

        public void WriteResourceToFile(string resourceName, string folder)
        {
            if (!IsValid)
                return;

            var fileName = Path.Combine(folder, resourceName);

            using (var resource = assembly.GetManifestResourceStream(resourceName))
            {
                using (var file = new FileStream(fileName, FileMode.Create, FileAccess.Write))
                {
                    resource.CopyTo(file);
                }
            }
        }
    }
}
