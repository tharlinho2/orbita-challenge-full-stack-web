namespace Alunos.Application.Resultado
{
    public abstract class Command : ICommand
    {
    }

    public abstract class Command<TResponse> : ICommand<TResponse>
    {
    }
}