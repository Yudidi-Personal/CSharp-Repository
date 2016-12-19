# 扩展方法的要求
---

1. requirements for classes
2. requirements for methods
3. requirements for parameter

## 语法格式
MethodEx(this 扩展的对象,扩展对象的参数)
```
//表示为IEnumerable<TSource>这类对象
public static IEnumerable<TSource> Where<TSource>
	(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
```

# 扩展的一些运用

1. 使得Linq可以链接查询符
```
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
IEnumerable<string> query = names
	.Where(n => n.Contains("a"))
	.OrderBy(n => n.Length)
	.Select(n => n.ToUpper());
```

* Where, OrderBy, Select这几个扩展方法的签名：
```
 public static IEnumerable<TSource> Where<TSource>
	(this IEnumerable<TSource> source, Func<TSource, bool> predicate)

 public static IEnumerable<TSource> OrderBy<TSource, TKey>
	(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)

 public static IEnumerable<TResult> Select<TSource, TResult>
	(this IEnumerable<TSource> source, Func<TSource, TResult> selector)
``

2. 第三方包StringEx.


# References

[LINQ之路 4：LINQ方法语法](http://www.cnblogs.com/lifepoem/archive/2011/10/27/2226556.html)