namespace PoleThesaurus.Database.Move{
public interface IMoveDBA
{
    List<Move> getMovesForPoleName(PoleName name);
}
}