using System;

namespace Business
{
    public class UploadFileMetadata
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Url { get; set; }

        public UploadFileMetadata(string name, string description, string type, string url)
        {
            Id = Guid.NewGuid();
            Name = name;
            Description = description;
            Type = type;
            Url = url;
        }
    }
}
