C#. 

SearchWithLambdas
Passing Lambda Expression As Parameter
Using delegates you can pass a lambda expression as a parameter to a function, 
and then use it in LINQ queries. 
This can be done with Func<…> delegates.
If you want to pass a lambda expression to be used, for example, in Where clause, you need a Func<T, bool> delegate. 
Just hover the mouse over Where in your code, and IntelliSense would show you the required syntax.
Based on example from here: 
http://andreyzavadskiy.com/2016/02/11/c-sharp-passing-lambda-expression-as-parameter/


For some other examples: 
https://www.dotnetperls.com/lambda

