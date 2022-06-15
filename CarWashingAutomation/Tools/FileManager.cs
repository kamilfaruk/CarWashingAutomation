/* Coder by KFY */
using System;
using System.IO;
using System.Text;

namespace CarWashingAutomation.Tools
{
    public class FileManager : IDisposable
    {
        public void Dispose()
        {

        }
        public long GetSize(string _path)
        {
            try
            {
                long _b = new System.IO.FileInfo(_path).Length;
                long _kb = _b / 1024;
                long _mb = _kb / 1024;
                //long _gb = _mb / 1024;
                return _mb;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FileManager.GetSize -> ", _ex);
                return -1;
            }
        }
        public void Write(string _path, string _text)
        {
            try
            {
                using (FileStream fs = new FileStream(_path, FileMode.OpenOrCreate, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.Write(_text);
                        sw.Flush();
                    }
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FileManager.Write -> ", _ex);
            }
        }
        public void Delete(string _path)
        {
            try
            {
                if (FileExists(_path))
                {
                    File.Delete(_path);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FileManager.Delete -> ", _ex);
            }
        }
        public void Copy(string _sourcePath, string _targetPath)
        {
            try
            {
                if (FileExists(_sourcePath))
                {
                    File.Copy(_sourcePath, _targetPath, true);
                }
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FileManager.Copy -> ", _ex);
            }
        }
        public StringBuilder Read(string _path)
        {
            try
            {
                StringBuilder _sb = new StringBuilder();
                using (StreamReader _sr = File.OpenText(_path))
                {
                    _sb.Append(_sr.ReadToEnd());
                }
                return _sb;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FileManager.Read -> ", _ex);
                return null;
            }
        }

        public string GetLastCreatedFile(string _path)
        {
            try
            {
                string _lastCreationFile = "";
                DateTime _lastCreationDate = DateTime.Now.AddYears(-100);
                string[] _files = Directory.GetFiles(_path);
                foreach (string _file in _files)
                {
                    FileInfo _fileInfo = new FileInfo(_file);
                    DateTime _fileCreationDate = _fileInfo.CreationTime;
                    if (_lastCreationDate < _fileCreationDate)
                    {
                        _lastCreationFile = _file;
                        _lastCreationDate = _fileCreationDate;
                    }
                }
                return _lastCreationFile;
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FileManager.GetLastCreatedFile -> ", _ex);
                return null;
            }
        }

        public bool FileExists(string _path)
        {
            return File.Exists(_path);
        }
        public bool DirectoryExists(string _path)
        {
            return Directory.Exists(_path);
        }
        public void CreateDirectory(string _path)
        {
            try
            {
                Directory.CreateDirectory(_path);
            }
            catch (Exception _ex)
            {
                Logger.WriteLog("FileManager.CreateDirectory -> ", _ex);
            }
        }
        public void CreatFile(string _path)
        {
            try
            {
                File.Create(_path);
            }
            catch (Exception _ex)
            {
                Console.WriteLine("FileManager.CreateFile =>", _ex);
            }
        }
        public static void FileWatcher_Created(string _path, FileSystemEventHandler _createdEvent)
        {
            try
            {
                FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
                fileSystemWatcher.Path = _path;
                fileSystemWatcher.Created += _createdEvent;
                fileSystemWatcher.EnableRaisingEvents = true;
            }
            catch (Exception _ex)
            {
                Console.WriteLine("FileManager.FileWatcher_Created =>", _ex);
            }
        }
        public static void FileWatcher_Renamed(string _path, RenamedEventHandler _renamedEvent)
        {
            try
            {
                FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
                fileSystemWatcher.Path = _path;
                fileSystemWatcher.Renamed += _renamedEvent;
                fileSystemWatcher.EnableRaisingEvents = true;
            }
            catch (Exception _ex)
            {
                Console.WriteLine("FileManager.FileWatcher_Renamed =>", _ex);
            }
        }
        public static void FileWatcher_Deleted(string _path, FileSystemEventHandler _deletedEvent)
        {
            try
            {
                FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();
                fileSystemWatcher.Path = _path;
                fileSystemWatcher.Deleted += _deletedEvent;
                fileSystemWatcher.EnableRaisingEvents = true;
            }
            catch (Exception _ex)
            {
                Console.WriteLine("FileManager.FileWatcher_Deleted =>", _ex);
            }
        }
    }
}
