namespace PoleThesaurus.Objects.PoleName{
public class PoleName:IPoleName{

    private ILocation location = new UnknownLocation();
    private String name = "";
    private ITimeRange timeRange = new UnkownTimeRange();
    private GUID _id;

    public PoleName(){
    }

    public void setLocation(ILocation location){
        this.location = location;
    }

    public ILocation getLocation(){
        return location;
    }

    public String getName(){
        return name;
    }

    public void setTimeRange(ITimeRange timeRange){
        this.timeRange = timeRange;
    }

    public ITimeRange getTimeRange(){
        return timeRange;
    }

    public GUID getID(){
        return _id;
    }
}
}