namespace LeetCodePractice.DataStructures;

/// <summary>
/// 链表节点
/// 用于链表相关算法题
/// </summary>
public class ListNode(int val = 0, ListNode? next = null)
{
    public int Val { get; set; } = val;
    public ListNode? Next { get; set; } = next;
}
