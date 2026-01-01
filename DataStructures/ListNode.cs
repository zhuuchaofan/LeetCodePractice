namespace LeetCodePractice.DataStructures;

/// <summary>
/// 链表节点
/// 用于链表相关算法题
/// </summary>
public class ListNode
{
    public int Val { get; set; }
    public ListNode? Next { get; set; }

    public ListNode(int val = 0, ListNode? next = null)
    {
        Val = val;
        Next = next;
    }
}
