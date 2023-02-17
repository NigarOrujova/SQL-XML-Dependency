﻿using System.Reflection;

namespace XML_Dependency.BackgraundServices
{
    public class BackgroundWorkerService : BackgroundService
    {
        private FileSystemWatcher watcher;

        protected override Task ExecuteAsync(CancellationToken stoppingToken)
        {
            watcher = new();
            watcher.Path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
            watcher.Filter = "*.xml";
            //watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
            watcher.Changed += On_Changed;

            return Task.CompletedTask;
        }
        void On_Changed(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine("Isliyir xml");
        }
    }
}
