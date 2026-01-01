namespace LeetCodePractice.Solutions.LinkedList;

using LeetCodePractice.DataStructures;

/// <summary>
/// LeetCode 2. 两数相加 (Add Two Numbers)
/// https://leetcode.cn/problems/add-two-numbers/
/// 
/// 难度: 中等
/// 标签: 链表, 数学, 递归
/// </summary>
public class Lc0002AddTwoNumbers
{
    /// <summary>
    /// 解法：迭代法 + 哨兵节点
    /// 
    /// 思路：
    /// 1. 使用哨兵节点简化边界处理
    /// 2. 同时遍历两个链表，逐位相加
    /// 3. 处理进位（sum >= 10 时进 1）
    /// 4. 注意处理最后可能存在的进位
    /// 
    /// 时间复杂度: O(max(m, n)) - m, n 分别为两个链表的长度
    /// 空间复杂度: O(1) - 不计算结果链表的空间
    /// </summary>
    public ListNode? AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        // 哨兵节点，简化头节点处理
        var dummy = new ListNode(0);
        var curr = dummy;
        var carry = 0;

        // 只要有链表未遍历完，或者还有进位，就继续
        while (l1 != null || l2 != null || carry > 0)
        {
            // 取当前位的值，空节点用 0 代替
            var x = l1?.Val ?? 0;
            var y = l2?.Val ?? 0;

            // 计算当前位的和
            var sum = x + y + carry;

            // 更新进位
            carry = sum / 10;

            // 创建新节点存储当前位
            curr.Next = new ListNode(sum % 10);
            curr = curr.Next;

            // 移动指针
            l1 = l1?.Next;
            l2 = l2?.Next;
        }

        // 返回真正的头节点（跳过哨兵）
        return dummy.Next;
    }
}
