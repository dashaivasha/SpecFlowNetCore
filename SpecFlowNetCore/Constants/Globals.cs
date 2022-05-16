﻿using System;
using System.IO;

namespace SpecFlowNetCore.Constants
{
    static class Globals
    {
        private static string _workingDirectory = Environment.CurrentDirectory;
        private static string _projectDirectory = Directory.GetParent(_workingDirectory).Parent.Parent.FullName;
        public static string DataPath = $"{_projectDirectory}{Path.DirectorySeparatorChar}TestData{Path.DirectorySeparatorChar}TestData.json";
        public static string PetPath = $"{_projectDirectory}{Path.DirectorySeparatorChar}TestData{Path.DirectorySeparatorChar}Pet.json";
        public static string OrderPath = $"{_projectDirectory}{Path.DirectorySeparatorChar}TestData{Path.DirectorySeparatorChar}Order.json";
        public static string DriverPath = $"{_projectDirectory}{Path.DirectorySeparatorChar}TestData";
    }
}
