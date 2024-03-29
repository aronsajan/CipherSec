﻿using Ionic.Zip;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CipherSecBase.CompressionSubsystem
{
   public class CompressionManager
    {
        public static void CompressDirectory(String DirectoryPath, String CompressOutputFile)
        {
            if(!Directory.Exists(DirectoryPath))
            {
                throw new ApplicationException("Directory compression failed. Details - " + DirectoryPath + " does not exists");
            }
            using (ZipFile zip = new ZipFile())
            {
                zip.AddDirectory(DirectoryPath);
                zip.Save(CompressOutputFile);
            }
        }

        public static void DecompressDirectory(String ZipPath, String TargetFile)
        {
            using (ZipFile zip = ZipFile.Read(ZipPath))
            {
                zip.ExtractAll(TargetFile, ExtractExistingFileAction.DoNotOverwrite);
            }
        }
    }
}
