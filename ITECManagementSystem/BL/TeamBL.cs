using ITECManagementSystem.Models.ITECManagementSystem.Models;
using ITECManagementSystem.Models;

public class TeamBL
{
    TeamDL teamDL = new TeamDL();
    public bool AddTeam(Team team, List<int> participantIds)
    {
        return teamDL.InsertTeam(team, participantIds);
    }
    public List<Participant> GetParticipants()
    {
        return teamDL.GetAllParticipants();
    }
}
