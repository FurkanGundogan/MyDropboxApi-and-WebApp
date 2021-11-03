﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models
{
    public class FileModel
    {
        
        public string filename { get; set; }

        public string filesize { get; set; }
        public HttpPostedFileBase filedata { get; set; }
        public byte[] filebytes { get; set; }

        public string filepath { get; set; }
        public FileModel(string filename, string filesize,string filepath)
        {
            
            this.filename = filename;
            this.filesize = filesize;
            this.filepath = filepath;
           
        }
        public FileModel() { 
        }
    }
}