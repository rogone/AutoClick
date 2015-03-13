#编译不过
##添加引用
* ACorns.Hawkeye.Core
* ACorns.Hawkeye.Injector
* MouseKeyboardLibrary

##事件类型与MouseKeyboardLibrary中的委托类型不符
* 将事件类型改成MouseKeyboardLibrary中定义的类型

##找不到NativeUtils.method方法
这些方法都是win32方法，自行Dllimport吧
