namespace LeetCodePractice.DataStructures;

/// <summary>
/// 二叉树节点
/// 用于树相关算法题
/// </summary>
public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int Val { get; set; } = val;
    public TreeNode? Left { get; set; } = left;
    public TreeNode? Right { get; set; } = right;
}
