

# Xml operations

1. Create,insert

1.1 XContainer.Descendants

2. Search,insert

Q: diff: Elements() | Descendants()
A: directly child | all child in every position.

# Work with NameSpace

1. default namespace: xmlns --> XNamespace.Xmlns
```
<Root xmlns="Name sapce one">
  <Childs xmlns="Name sapce two">
    <child xmlns="">1</child>
    <child xmlns="">2</child>
  </Childs>
</Root>
```
2. control the prefixes of the namespace
https://msdn.microsoft.com/en-us/library/bb387069(v=vs.110).aspx
```
```


# Functions
---
# 1. Create xml according to two template XML files -- 用于格式固定的xml的一次生成

# 2.


# References
0. base 
http://www.cnblogs.com/a1656344531/archive/2012/11/28/2792863.html

1. C#操作XML的完整例子——XmlDocument篇
http://blog.csdn.net/cds27/article/details/2305166


2. LINQ to XML 编程基础
http://www.cnblogs.com/luckdv/articles/1728088.html