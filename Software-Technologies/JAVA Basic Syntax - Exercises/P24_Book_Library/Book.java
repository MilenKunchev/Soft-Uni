package P24_Book_Library;

import java.time.LocalDate;

public class Book {
    private String title;
    private String author;
    private String publisher;
    private LocalDate releasedDate;
    private String isbn;
    private double price;

    public Book(String title, String author, String publisher, LocalDate releasedDate, String isbn, double price) {
        this.title = title;
        this.author = author;
        this.publisher = publisher;
        this.releasedDate = releasedDate;
        this.isbn = isbn;
        this.price = price;
    }

    public String getTitle() {
        return title;
    }

    public String getAuthor() {
        return author;
    }

    public String getPublisher() {
        return publisher;
    }

    public LocalDate getReleasedDate() {
        return releasedDate;
    }

    public String getIsbn() {
        return isbn;
    }

    public double getPrice() {
        return price;
    }
}
