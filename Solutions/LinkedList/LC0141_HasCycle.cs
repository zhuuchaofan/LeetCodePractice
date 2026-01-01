namespace LeetCodePractice.Solutions.LinkedList;

using LeetCodePractice.DataStructures;

public class Lc0141HasCycle {
    public bool HasCycle(ListNode? head) {
        // 1. 防御性编程：如果是 空链表或单节点，不可能成环
        if (head?.Next == null) return false;

        // 2. 初始化双指针
        var slow = head;
        var fast = head;

        // 3. 开始赛跑
        // 关键点：我们只关心兔子能不能跑
        // fast != null 保证当前不是终点
        // fast.Next != null 保证兔子能跳出这一步（不然访问 Next.Next 会崩）
        while (fast is { Next: not null }) {
            slow = slow?.Next;       // 慢指针走一步
            fast = fast.Next.Next;  // 快指针走两步

            // 4. 检查是否相遇
            // C# 知识点：对于引用类型，== 比较的是“内存地址”是否相同
            // 也就是判断它们是不是指向堆内存中的同一个对象
            if (slow == fast) {
                return true; // 抓到了，有环！
            }
        }

        // 5. 兔子冲出了跑道（遇到了 null），说明是直线，没环
        return false;
    }
}
