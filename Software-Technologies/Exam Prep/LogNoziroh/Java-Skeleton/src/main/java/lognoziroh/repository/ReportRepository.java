package lognoziroh.repository;

import org.springframework.data.jpa.repository.JpaRepository;
import lognoziroh.entity.Report;

import java.util.List;

public interface ReportRepository extends JpaRepository<Report, Integer> {
    List<Report> findAllByStatus(String status); // might be helpful?
}
