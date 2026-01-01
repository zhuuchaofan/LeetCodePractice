using LeetCodePractice.DataStructures;
using LeetCodePractice.Solutions.LinkedList;

Console.WriteLine("=== LeetCode Practice ===\n");

/*
// 测试 LC0206: 反转链表
TestReverseList();

// 测试 LC0141: 环形链表
TestHasCycle();

// 测试 LC0002: 两数相加
TestLc0002();
*/

/*
void TestReverseList()
{
    Console.WriteLine("📌 LC0206: 反转链表 (Reverse Linked List)");
    Console.WriteLine("────────────────────────────────────────");

    var solution = new Lc0206ReverseList();

    // 用例 1: 正常链表
    // 1 -> 2 -> 3 -> 4 -> 5
    var head1 = new ListNode(1, new ListNode(2, new ListNode(3, new ListNode(4, new ListNode(5)))));
    Console.Write("  原链表: "); PrintList(head1);

    var result1 = solution.ReverseList(head1);
    Console.Write("  反转后: "); PrintList(result1);
    Console.WriteLine("  预期  : 5 -> 4 -> 3 -> 2 -> 1");
}

void TestHasCycle()
{
    Console.WriteLine("📌 LC0141: 环形链表 (Linked List Cycle)");
    Console.WriteLine("─────────────────────────────────────");

    var solution = new Lc0141HasCycle();

    // 用例 1: 有环
    // 3 -> 2 -> 0 -> -4 -> (回到 2)
    var node1 = new ListNode(3);
    var node2 = new ListNode(2);
    var node3 = new ListNode(0);
    var node4 = new ListNode(-4);
    node1.Next = node2;
    node2.Next = node3;
    node3.Next = node4;
    node4.Next = node2; // 形成环

    bool result1 = solution.HasCycle(node1);
    Console.WriteLine($"  用例 1 (有环): 结果 = {result1}, 预期 = True");

    // 用例 2: 无环
    // 1 -> 2
    var nodeA = new ListNode(1, new ListNode(2));
    bool result2 = solution.HasCycle(nodeA);
    Console.WriteLine($"  用例 2 (无环): 结果 = {result2}, 预期 = False");

    // 用例 3: 空链表
    bool result3 = solution.HasCycle(null);
    Console.WriteLine($"  用例 3 (空链表): 结果 = {result3}, 预期 = False");

    if (result1 && !result2 && !result3)
    {
        Console.WriteLine("  ✅ 测试通过！\n");
    }
    else
    {
        Console.WriteLine("  ❌ 测试失败！\n");
    }
}

void TestLc0002()
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
*/

// 辅助函数：打印链表
void PrintList(ListNode? node)
{
    if (node == null)
    {
        Console.WriteLine("null");
        return;
    }

    while (node != null)
    {
        Console.Write(node.Val);
        if (node.Next != null)
            Console.Write(" -> ");
        node = node.Next;
    }
    Console.WriteLine();
}
