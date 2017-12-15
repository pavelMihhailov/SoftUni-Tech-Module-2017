package imdb.entity;

import javax.persistence.*;

    @Entity
    @Table(name = "films")
    public class Film {
    private Integer id;

    private String name;

    private String genre;

    private String director;

    private Integer year;

    public Film() {

    }

        public Film(String name, String genre, String director, Integer year) {
            this.name = name;
            this.genre = genre;
            this.director = director;
            this.year = year;
        }

        @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    public Integer getId() {
        return this.id;
    }

    public void setId(Integer id) {
        this.id = id;
    }

    @Column(nullable = false)
    public String getName() {
        return this.name;
    }

    public void setName(String name) {
        this.name = name;
    }

    @Column(nullable = false)
    public String getGenre() {
        return this.genre;
    }

    public void setGenre(String genre) {
        this.genre = genre;
    }

    @Column(nullable = false)
    public String getDirector() {
        return this.director;
    }

    public void setDirector(String director) {
        this.director = director;
    }

    @Column(nullable = false)
    public Integer getYear() {
        return this.year;
    }

    public void setYear(Integer year) {
        this.year = year;
    }
}
