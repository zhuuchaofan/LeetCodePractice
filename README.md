# LeetCode Practice 🧠

我的 LeetCode 算法练习仓库，使用 C# (.NET 10) 实现。

## 📁 项目结构

```
LeetCodePractice/
├── DataStructures/           # 公共数据结构
│   ├── ListNode.cs           # 链表节点
│   └── TreeNode.cs           # 二叉树节点
├── Solutions/                # 题目解答 (按分类)
│   ├── Array/                # 数组
│   ├── Backtracking/         # 回溯
│   ├── BinarySearch/         # 二分查找
│   ├── DynamicProgramming/   # 动态规划
│   ├── Graph/                # 图
│   ├── Greedy/               # 贪心
│   ├── Heap/                 # 堆
│   ├── LinkedList/           # 链表
│   ├── Math/                 # 数学
│   ├── Other/                # 其他
│   ├── Queue/                # 队列
│   ├── SlidingWindow/        # 滑动窗口
│   ├── Stack/                # 栈
│   ├── String/               # 字符串
│   ├── Tree/                 # 树
│   └── TwoPointers/          # 双指针
├── Program.cs                # 测试入口
├── LeetCodePractice.sln      # 解决方案文件
├── LeetCodePractice.csproj   # 项目文件
├── .gitignore                # Git 忽略配置
└── README.md                 # 项目说明
```

## 🚀 运行方式

```bash
# 构建项目
dotnet build

# 运行测试
dotnet run
```

## 📝 代码规范

### 文件命名

```
LC{4位编号}_{题目英文名}.cs
```

示例: `LC0001_TwoSum.cs`, `LC0002_AddTwoNumbers.cs`

### 类结构

每个题目解答类应包含 XML 文档注释，说明题目链接、难度、标签以及复杂度分析。

```csharp
/// <summary>
/// LeetCode {编号}. {题目中文名} ({题目英文名})
/// https://leetcode.cn/problems/{slug}/
///
/// 难度: 简单/中等/困难
/// 标签: 标签1, 标签2
/// </summary>
public class LC0000_ProblemName
{
    /// <summary>
    /// 时间复杂度: O(?)
    /// 空间复杂度: O(?)
    /// </summary>
    public ReturnType MethodName(params)
    {
        // 解题代码
    }
}
```

## 📊 题目进度

| #   | 题目 | 难度 | 分类 | 解法 |
| --- | --- | --- | --- | --- |
| 2 | [两数相加](https://leetcode.cn/problems/add-two-numbers/) | 中等 | 链表 | [C#](Solutions/LinkedList/LC0002_AddTwoNumbers.cs) |
| 141 | [环形链表](https://leetcode.cn/problems/linked-list-cycle/) | 简单 | 链表 | [C#](Solutions/LinkedList/LC0002_HasCycle.cs) |

## 🔧 技术栈

- **语言**: C# 13.0
- **框架**: .NET 10
- **IDE**: JetBrains Rider / Visual Studio / VS Code

## 📜 License

MIT
