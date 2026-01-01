# GEMINI.md

## Project Overview

这是一个 LeetCode 算法练习项目，使用 C# 和 .NET 10 实现各种算法题目的解答。

### 技术栈

- **语言**: C# 13.0
- **框架**: .NET 10
- **结构**: 控制台应用程序

## 项目结构

```
LeetCodePractice/
├── DataStructures/    # 公共数据结构 (ListNode, TreeNode 等)
├── Solutions/         # 题目解答，按算法分类
│   ├── LinkedList/    # 链表
│   ├── Array/         # 数组
│   ├── Tree/          # 树
│   └── ...
├── Program.cs         # 测试入口
└── README.md          # 项目说明
```

## 开发规范

### 文件命名

- 题目文件: `LC{4位编号}_{英文题目名}.cs`
- 示例: `LC0002_AddTwoNumbers.cs`

### 代码结构

每个题目解答类应包含:

1. XML 文档注释（题目链接、难度、标签）
2. 解题方法及复杂度分析
3. 可选：多种解法

### 命名空间

- 数据结构: `LeetCodePractice.DataStructures`
- 题目解答: `LeetCodePractice.Solutions.{分类名}`

## 构建和运行

```bash
# 构建
dotnet build

# 运行测试
dotnet run
```
