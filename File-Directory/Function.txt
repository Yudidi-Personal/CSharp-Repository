# 使用FileInfo对单个文件执行多次操作creation->writing->opening->reading.

# 判断是文件还是目录的两种方法 
1. 取其Attributes属性进行与运算,
*只有相同的值&运算结果为相同值
*a&b: 只有a==b时,a&b==b.全真为真1&1==1.
*a|b: 0|0=0,全假为假.
```
if ((fsi.Attributes & FileAttributes.Directory) == FileAttributes.Directory){ entryType = "Directory";}
```
2. 强转后进行判空
```
 DirectoryInfo dir = info as DirectoryInfo;if( dir == null ) return; //不是目录
```

# 序列化
1. BinaryFormatter
2. 流程
对象-->存入文件;
读文件-->生成对象