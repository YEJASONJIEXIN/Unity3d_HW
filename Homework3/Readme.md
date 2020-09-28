# 作业内容

## 1、简答并用程序验证【建议做】

游戏对象运动的本质是什么？
请用三种方法以上方法，实现物体的抛物线运动。（如，修改Transform属性，使用向量Vector3的方法…）
写一个程序，实现一个完整的太阳系， 其他星球围绕太阳的转速必须不一样，且不在一个法平面上。
## 2、编程实践

阅读以下游戏脚本
```
Priests and Devils

Priests and Devils is a puzzle game in which you will help the Priests and Devils to cross the river within the time limit. There are 3 priests and 3 devils at one side of the river. They all want to get to the other side of this river, but there is only one boat and this boat can only carry two persons each time. And there must be one person steering the boat from one side to the other side. In the flash game, you can click on them to move them and click the go button to move the boat to the other direction. If the priests are out numbered by the devils on either side of the river, they get killed and the game is over. You can try it in many > ways. Keep all priests alive! Good luck!

```
程序需要满足的要求：

play the game ( http://www.flash-game.net/game/2535/priests-and-devils.html )
列出游戏中提及的事物（Objects）
用表格列出玩家动作表（规则表），注意，动作越少越好
请将游戏中对象做成预制
在场景控制器 LoadResources 方法中加载并初始化 长方形、正方形、球 及其色彩代表游戏中的对象。
使用 C# 集合类型 有效组织对象
整个游戏仅 主摄像机 和 一个 Empty 对象， 其他对象必须代码动态生成！！！ 。 整个游戏不许出现 Find 游戏对象， SendMessage 这类突破程序结构的 通讯耦合 语句。 违背本条准则，不给分
请使用课件架构图编程，不接受非 MVC 结构程序
注意细节，例如：船未靠岸，牧师与魔鬼上下船运动中，均不能接受用户事件！
3、思考题【选做】

使用向量与变换，实现并扩展 Tranform 提供的方法，如 Rotate、RotateAround 等