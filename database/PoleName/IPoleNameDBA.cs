namespace PoleThesaurus.Database.PoleName{
public interface IPoleNameDBA
{
    List<PoleName> getPoleNamesForMove(Move move);
}
}