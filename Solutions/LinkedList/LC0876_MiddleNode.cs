using LeetCodePractice.DataStructures;

namespace LeetCodePractice.Solutions.LinkedList;

public class Lc0876MiddleNode
{
    public ListNode? MiddleNode(ListNode? head) {
        // 继承自 LeetCode 141 的肌肉记忆：定义双指针
        var slow = head;
        var fast = head;

        // 唯一的区别在于停止条件：
        // 第141题是看 fast 是否追上 slow
        // 第876题是看 fast 是否跑到尽头
        while (fast is { Next: not null }) {
            slow = slow?.Next;       // 1x 速度
            fast = fast.Next.Next;  // 2x 速度
        }

        // 当博尔特到达终点，普通人就在中间
        return slow;
    }


}
