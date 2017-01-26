/*
Problem 7. Min and Max

* Create generic methods Min<T>() and Max<T>() for finding the minimal and maximal element in the GenericList<T>.
* You may need to add a generic constraints for the type T.
*/

using System;

namespace Problem_07
{
    class Program
    {
        static void Main()
        {
            GenericList<int> numbers = new GenericList<int>();
            for (int i = 0; i < 256; i++)
            {
                numbers.Add(i * 2);
            }

            Console.WriteLine("Min: {0}", numbers.Min<int>());
            Console.WriteLine("Max: {0}", numbers.Max<int>());
            Console.WriteLine();

            string[] separators = { " ", ".", ",", "-", "?", "!", ":" };
            string[] lorem = "Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, qui dolorem ipsum, quia dolor sit amet consectetur adipiscing velit, sed quia non numquam do eius modi tempora incididunt, ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur? Quis autem vel eum iure reprehenderit, qui in ea voluptate velit esse, quam nihil molestiae consequatur, vel illum, qui dolorem eum fugiat, quo voluptas nulla pariatur? At vero eos et accusamus et iusto odio dignissimos ducimus, qui blanditiis praesentium voluptatum deleniti atque corrupti, quos dolores et quas molestias excepturi sint, obcaecati cupiditate non provident, similique sunt in culpa, qui officia deserunt mollitia animi, id est laborum et dolorum fuga. Et harum quidem rerum facilis est et expedita distinctio.Nam libero tempore, cum soluta nobis est eligendi optio, cumque nihil impedit, quo minus id, quod maxime placeat, facere possimus, omnis voluptas assumenda est, omnis dolor repellendus. Temporibus autem quibusdam et aut officiis debitis aut rerum necessitatibus saepe eveniet, ut et voluptates repudiandae sint et molestiae non recusandae. Itaque earum rerum hic tenetur a sapiente delectus, ut aut reiciendis voluptatibus maiores alias consequatur aut perferendis doloribus asperiores repellat…"
                             .Split(separators, StringSplitOptions.RemoveEmptyEntries);
            GenericList<string> words = new GenericList<string>();
            foreach (var item in lorem)
            {
                //words = 
                          words.Add(item);
            }


            Console.WriteLine("Min: {0}", words.Min<string>());
            Console.WriteLine("Max: {0}", words.Max<string>());
            Console.WriteLine();
        }
    }
}
