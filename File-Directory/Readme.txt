# File VS FileInfo
## 1. File is a static class.
1.1 All File methods are static.
1.2 The static methods of the File class perform security checks on all methods.

## 2. FileInfo is instant class.
2.1 When the properties are first retrieved,FileInfo calls the Refresh method and caches information about the file.
---

# Directory.GetDirectories Method (path, searchPattern)

1. searchPattern:"t*","*t","?bc". But the parameter doesn't support regular expressions.
2. 大量操作时使用Directory.EnumerateDirectories替换Directory.GetDirectories,可以减少时间.
---

# FileSystemInfo 
Q1:FileInfo VS File
A1: instance|static (class,methods)
A2: security checks
A3: catch information.-->FileSystemInfo.Refresh方法
---

# FileSystemWatcher

# FAQ:
