# LeetCode Practice 🧠

我的 LeetCode 算法练习仓库，使用 C# (.NET 10) 实现。

## 📁 项目结构

```
LeetCodePractice/
├── DataStructures/           # 公共数据结构
│   ├── ListNode.cs           # 链表节点
│   └── TreeNode.cs           # 二叉树节点
│
├── Solutions/                # 题目解答 (按分类)
│   ├── LinkedList/           # 链表
│   ├── Array/                # 数组
│   ├── String/               # 字符串
│   ├── Tree/                 # 树
│   ├── DynamicProgramming/   # 动态规划
│   └── ...
│
└── Program.cs                # 测试入口
```

## 🚀 运行方式

```bash
dotnet run
```

## 📝 代码规范

### 文件命名

```
LC{编号}_{题目英文名}.cs
```

示例: `LC0001_TwoSum.cs`, `LC0002_AddTwoNumbers.cs`

### 类结构

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

| #   | 题目                                                      | 难度 | 分类 | 解法                                               |
| --- | --------------------------------------------------------- | ---- | ---- | -------------------------------------------------- |
| 2   | [两数相加](https://leetcode.cn/problems/add-two-numbers/) | 中等 | 链表 | [C#](Solutions/LinkedList/LC0002_AddTwoNumbers.cs) |

## 🔧 技术栈

- **语言**: C# 13
- **框架**: .NET 10
- **IDE**: Rider / VS Code

## 📜 License

MIT
