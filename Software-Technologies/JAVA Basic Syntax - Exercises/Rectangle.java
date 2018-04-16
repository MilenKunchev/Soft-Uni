public class Rectangle {

    private double width;
    private double height;


    //Default Constructor
    public Rectangle(){

    }
    // Constructor
    public Rectangle(double width , double height){

        this.setWidth(width);
        this.setHeight(height);
    }

    public double getWidth() {
        return this.width;
    }

    private void setWidth(double width) {
        this.width = width;

    }

    public double getHeight() {
        return this.height;
    }

    private void setHeight(double height) {
        this.height = height;
    }

    public double getArea() {
        return width * height;
    }

    public double getPerimetter() {
        return this.height * 2 + this.width * 2;
    }

    @Override
    public String toString() {
        return String.format("Height = %.2f\nWidth = %.2f", this.getHeight(), this.getWidth());
    }
}
