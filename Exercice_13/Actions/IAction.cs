namespace Exercice_11
{
    public interface IAction
    {
        /// <summary>
        /// Execute l'action sur la ménagerie
        /// </summary>
        /// <param name="menagerie"></param>
        void Execute(Menagerie menagerie);
    }
}
