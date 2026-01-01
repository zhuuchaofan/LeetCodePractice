using LeetCodePractice.DataStructures;

namespace LeetCodePractice.Solutions.LinkedList;

public class Lc0206ReverseList
{
    public ListNode? ReverseList(ListNode head) {
        // 【配置阶段】
        // prev 初始化为 null，构建反转后的“落地”终点
        ListNode? prev = null;
        var curr = head;

        while (curr != null) {
            // Step 1: 挂安全绳 (Save)
            // 必须最先做！一旦执行 Step 2，curr.next 就会改变，
            // 如果不存，后面的链表就因“内存泄漏”而永远丢失了。
            var next = curr.Next; 

            // Step 2: 斩断与重连 (Mutate)
            // 核心动作：将当前节点的指针，由指向“后面”，改为指向“前面”。
            curr.Next = prev;

            // Step 3: 推进窗口 (Shift)
            // 只有当前节点处理完毕，prev 才能上位，curr 才能去下一个待办点。
            prev = curr;
            curr = next;
        }

        // 【交付阶段】
        // 循环结束时 curr 是 null，prev 才是最后的非空节点（新头）
        return prev;
    }

}