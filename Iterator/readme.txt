
# 本质
http://blog.csdn.net/xuemoyao/article/details/8047513

9、yield关键字

我们知道如果想要能够foreach遍历的话，必须要实现IEnumerable接口，GetEnumerator()方法，而yield关键字是用来帮助IEnumerable对象自动生成一个辅助IEnumerator对象。但是yield关键字只能用在retur关键字或break关键字之前。

请看示例：(该示例引自Rookie_J博客）

(1)定义一个实现了接口IEnumerable的类MyYield:

class MyYield : IEnumerable
  {
  publicint StartCountdown; 
public IEnumerator GetEnumerator()
       {
  for (int i= StartCountdown; i>=0; i--)
  yieldreturn i;//yield自动生成一个实现了接口IEnumerator的类
     }
}


# 使用
http://www.cnblogs.com/gc2013/p/4055925.html

1、yield return能返回一个"按需供给"的集合 
2、yield return是"语法糖"，其背后是一个实现了IEnuerable,IEnumerator泛型、非泛型接口的类，该类维护着一个状态字段，以保证yield return产生的集合能"按需供给" 
3、yield break配合yield return使用，当产生集合达到某种条件的时候使用yield break，以终止继续创建集合
