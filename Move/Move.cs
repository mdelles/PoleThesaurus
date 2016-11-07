public class Move:IMove{

    private Image _poleImage;
    private GUID _id;

    public Move(){
        
    }

    public Image getImage(){
        return _poleImage;
    }

    public GUID getID(){
        return _id;
    }
}