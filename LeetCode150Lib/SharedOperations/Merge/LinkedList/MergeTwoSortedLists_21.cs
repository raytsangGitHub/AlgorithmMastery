namespace LeetCode150Lib.SharedOperations.Merge.LinkedList
{
    //Definition for singly-linked list.
    //public class ListNode<T>
    //{
    //    public T val;
    //    public ListNode<T>? next;

    //    public ListNode(T val = default!, ListNode<T>? next = null)
    //    {
    //        this.val = val;
    //        this.next = next;
    //    }
    //}

    /// <summary>
    /// You are given the heads of two sorted linked lists list1 and list2.
    /// Merge the two lists into one sorted list.The list should be made by splicing together the nodes of the first two lists.
    /// Return the head of the merged linked list.
    /// </summary>
    public class MergeTwoSortedLists_21 : IAlgoMasteryOperation<List<int>>
    {
        private readonly LinkedList<int>? _result = new();  //store the result

        //the implementation will have the object[] will take in LinkedList
        public List<int> Execute(params object[] parameters)
        {
            //check either or both list are empty, return empty list []
            if (parameters[0] == null) return ((LinkedList<int>)parameters[1]).ToList();
            if (parameters[1] == null) return ((LinkedList<int>)parameters[0]).ToList();

            //create a new LinkedList<int> instance, and sorted in ascending order
            LinkedList<int>? list1 = new LinkedList<int>(((LinkedList<int>)parameters[0]).OrderBy(x => x));

            LinkedList<int>? list2 = new LinkedList<int>(((LinkedList<int>)parameters[1]).OrderBy(x => x));

            //set the pointer to first node
            LinkedListNode<int>? node1 = list1.First;
            LinkedListNode<int>? node2 = list2.First;

            // Merge the two sorted linked, using two-pointer
            while (node1 != null && node2 != null)
            {
                if (node1.Value <= node2.Value)
                {
                    _result.AddLast(node1.Value);
                    node1 = node1.Next;
                }
                else
                {
                    _result.AddLast(node2.Value);
                    node2 = node2.Next;
                }
            }

            // Append the remaining nodes from either list1 or list2
            while (node1 != null)
            {
                _result.AddLast(node1.Value);
                node1 = node1.Next;
            }

            while (node2 != null)
            {
                _result.AddLast(node2.Value);
                node2 = node2.Next;
            }
            //convert to the list as return type
            return _result.ToList();
        }
    }
}