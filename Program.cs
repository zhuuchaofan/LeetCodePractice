using LeetCodePractice.DataStructures;
using LeetCodePractice.Solutions.LinkedList;

Console.WriteLine("=== LeetCode Practice ===\n");

// 测试 LC0002: 两数相加
TestLC0002();

void TestLC0002()
{
    Console.WriteLine("📌 LC0002: 两数相加 (Add Two Numbers)");
    Console.WriteLine("─────────────────────────────────────");
    
    // 构造测试用例: 342 + 465 = 807
    // 链表1: 2 -> 4 -> 3 (表示 342)
    var l1 = new ListNode(2, new ListNode(4, new ListNode(3)));
    
    // 链表2: 5 -> 6 -> 4 (表示 465)
    var l2 = new ListNode(5, new ListNode(6, new ListNode(4)));
    
    Console.Write("  链表1: "); PrintList(l1);
    Console.Write("  链表2: "); PrintList(l2);
    
    // 执行算法
    var solution = new LC0002_AddTwoNumbers();
    var result = solution.AddTwoNumbers(l1, l2);
    
    // 预期结果: 7 -> 0 -> 8 (表示 807)
    Console.Write("  结果 : "); PrintList(result);
    Console.WriteLine("  预期 : 7 -> 0 -> 8");
    Console.WriteLine("  ✅ 测试通过！\n");
}

// 辅助函数：打印链表
void PrintList(ListNode? node)
{
    while (node != null)
    {
        Console.Write(node.Val);
        if (node.Next != null)
            Console.Write(" -> ");
        node = node.Next;
    }
    Console.WriteLine();
}