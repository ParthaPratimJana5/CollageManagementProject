 -- create database
create database dbCollageManagementSyatem;


use dbCollageManagementSyatem;


-- =========================
-- gender table
-- =========================
create table tblGender (
    GenderId int primary key identity(1,1),
    GenderName varchar(max) not null
);

-- =========================
-- designation table
-- =========================
create table tblDesignation (
    DesignationId int primary key identity(1,1),
    DesignationName varchar(max) not null
);

-- =========================
-- department table
-- =========================
create table tblDepartment (
    DepartmentId int primary key identity(1,1),
    DepartmentName varchar(max) not null
);

-- =========================
-- address table
-- =========================
create table tblAddress (
    AddressId int primary key identity(1,1),
    CareOf varchar(max) null,
    Village varchar(max) null,
    Post varchar(max) null,
    Pin varchar(max) null,
    Aadhaar varchar(max) null,
    PhoneNumber varchar(max) null,
    GuardianPhone varchar(20) null,
    GuardianEmail Varchar(50)null
);

-- =========================
-- bank table
-- =========================
create table tblBank (
    BankId int primary key identity(1,1),
    BankName varchar(max) null,
    BranchName varchar(max) null,
    IFSC varchar(max) null,
    AccountNumber varchar(max) null
);

-- =========================
-- photos table
-- =========================
create table tblPhotos (
    PhotoId int primary key identity(1,1),
    Photo varbinary(max) not null
);

-- =========================
-- cv table
-- =========================
create table tblCV (
    CVId int primary key identity(1,1),
    CV varbinary(max) not null
);

-- =========================
-- staff table
-- =========================
create table tblStaff (
    StaffId int primary key identity(1,1),
    StaffName varchar(max) null,
    Email varchar(max) null,
    DateOfJoinning date null,
    Salary float null,
    BloodGroup varchar(10) null,
    GenderId int not null foreign key references tblGender(GenderId),
    DesignationId int not null foreign key references tblDesignation(DesignationId),
    BankId int not null foreign key references tblBank(BankId),
    AddressId int not null foreign key references tblAddress(AddressId),
    DepartmentId int not null foreign key references tblDepartment(DepartmentId),
    PhotoId int not null foreign key references tblPhotos(PhotoId),
    CVId int not null foreign key references tblCV(CVId)
);

-- =========================
-- hod table
-- =========================
create table tblHOD (
    HODId int primary key identity(1,1),
    StaffId int not null foreign key references tblStaff(StaffId),
    DepartmentId int not null foreign key references tblDepartment(DepartmentId)
);

-- =========================
-- course table
-- =========================
create table tblCourse (
    CourseId int primary key identity(1,1),
    CourseName varchar(max) not null,
    Duration varchar(max) not null,
    DepartmentId int not null foreign key references tblDepartment(DepartmentId)
);

-- =========================
-- students table
-- =========================
create table tblStudents (
    StudentId int primary key identity(1,1),
    StudentName varchar(max) null,
    DateOfBirth date null,
    GenderId int not null foreign key references tblGender(GenderId),
    Email varchar(max) null,
    Phone varchar(max) null,
    BloodGroup varchar (max) null,

    AddressId int not null foreign key references tblAddress(AddressId),
    PhotoId int not null foreign key references tblPhotos(PhotoId)
);

-- =========================
-- subjects table
-- =========================
create table tblSubjects (
    SubjectId int primary key identity(1,1),
    SubjectName varchar(max) not null,
    CourseId int not null foreign key references tblCourse(CourseId),
    StaffId int not null foreign key references tblStaff(StaffId)
);

-- =========================
-- enrollment table
-- =========================
create table tblEnrollment (
    EnrollmentId int primary key identity(1,1),
    StudentId int not null foreign key references tblStudents(StudentId),
    CourseId int not null foreign key references tblCourse(CourseId),
    AdmissionDate date not null
);

-- =========================
-- attendance table
-- =========================
create table tblAttendance (
    AttendanceId int primary key identity(1,1),
    StudentId int not null foreign key references tblStudents(StudentId),
    SubjectId int not null foreign key references tblSubjects(SubjectId),
    AttendanceDate date not null,
    Status varchar(max) not null
);

-- =========================
-- exam table
-- =========================
create table tblExam (
    ExamId int primary key identity(1,1),
    ExamDate date not null,
    SubjectId int not null foreign key references tblSubjects(SubjectId),
    TotalMarks int not null
);

-- =========================
-- result table
-- =========================
create table tblResult (
    ResultId int primary key identity(1,1),
    StudentId int not null foreign key references tblStudents(StudentId),
    ExamId int not null foreign key references tblExam(ExamId),
    MarksObtained int not null,
    Grade varchar(max) not null
);

-- =========================
-- payment purpose table
-- =========================
create table tblPaymentPurpose (
    PaymentPurposeId int primary key identity(1,1),
    PaymentPurpose varchar(max) not null
);

-- =========================
-- payment type table
-- =========================
create table tblPaymentType (
    PayTypeId int primary key identity(1,1),
    PayType varchar(max) not null
);

-- =========================
-- payment table
-- =========================
create table tblPayment (
    PaymentId int primary key identity(1,1),
    StudentId int not null foreign key references tblStudents(StudentId),
    PayTypeId int not null foreign key references tblPaymentType(PayTypeId),
    Amount bigint not null,
    PaymentPurposeId int not null foreign key references tblPaymentPurpose(PaymentPurposeId),
    DateOfPayment date not null,
    Description varchar(max) null
);


-- =========================
-- Blood Group table
-- =========================
create table tblBloodGroup (
    BloodGroupId int primary key identity(1,1),
    BloodGroupName varchar(10) not null
);

-- =========================
-- Insert common blood groups
-- =========================
insert into tblBloodGroup (BloodGroupName) values ('A+');
insert into tblBloodGroup (BloodGroupName) values ('A-');
insert into tblBloodGroup (BloodGroupName) values ('B+');
insert into tblBloodGroup (BloodGroupName) values ('B-');
insert into tblBloodGroup (BloodGroupName) values ('AB+');
insert into tblBloodGroup (BloodGroupName) values ('AB-');
insert into tblBloodGroup (BloodGroupName) values ('O+');
insert into tblBloodGroup (BloodGroupName) values ('O-');

select * from tblBloodGroup


----------------------------------------------
-- Teasting data --

-- =========================
-- gender
-- =========================
insert into tblGender (GenderName) values ('Male'), ('Female'), ('Other');

-- =========================
-- designation
-- =========================
insert into tblDesignation (DesignationName) values 
('Principal'), ('Lecturer'), ('Accountant'), ('Clerk');

-- =========================
-- department
-- =========================
insert into tblDepartment (DepartmentName) values 
('Computer Science'), ('Business Administration'), ('English');

-- =========================
-- payment type
-- =========================
insert into tblPaymentType (PayType) values 
('Cash'), ('UPI'), ('Debit Card'), ('Credit Card');

-- =========================
-- payment purpose
-- =========================
insert into tblPaymentPurpose (PaymentPurpose) values 
('Admission Fee'), ('Examination Fee'), ('Library Fee'), ('Hostel Fee');

-- =========================
-- bank
-- =========================
insert into tblBank (BankName, BranchName, IFSC, AccountNumber) values
('SBI', 'Kolkata Main', 'SBIN0001234', '1234567890'),
('HDFC Bank', 'Salt Lake', 'HDFC0005678', '9876543210');

-- =========================
-- address
-- =========================
insert into tblAddress (CareOf, Village, Post, Pin, Aadhaar, PhoneNumber) values
('Mr. Roy', 'Bidhannagar', 'Salt Lake PO', '700064', '123412341234', '9876543210'),
('Mrs. Das', 'Howrah', 'Howrah PO', '711101', '567856785678', '9123456780');

-- =========================
-- photos (dummy binary)
-- =========================
insert into tblPhotos (Photo) values (0x1234), (0x5678);

-- =========================
-- cv (dummy binary)
-- =========================
insert into tblCV (CV) values (0x1111), (0x2222);

-- =========================
-- staff
-- =========================
insert into tblStaff (StaffName, Email, DateOfJoinning, Salary, BloodGroup, GenderId, DesignationId, BankId, AddressId, DepartmentId, PhotoId, CVId)
values
('Dr. S. Mukherjee', 'mukherjee@college.edu', '2020-07-01', 75000, 'A+', 1, 1, 1, 1, 1, 1, 1),
('Prof. A. Banerjee', 'banerjee@college.edu', '2021-01-15', 50000, 'B+', 2, 2, 2, 2, 2, 2, 2);

-- =========================
-- hod
-- =========================
insert into tblHOD (StaffId, DepartmentId) values (1, 1);

-- =========================
-- course
-- =========================
insert into tblCourse (CourseName, Duration, DepartmentId) values
('BCA', '3 Years', 1),
('BBA', '3 Years', 2);

-- =========================
-- students
-- =========================
insert into tblStudents (StudentName, DateOfBirth, GenderId, Email, Phone, AddressId, PhotoId)
values
('Rahul Sharma', '2003-05-12', 1, 'rahul@college.edu', '9998887776', 1, 1),
('Priya Sen', '2004-08-20', 2, 'priya@college.edu', '8887776665', 2, 2);

-- =========================
-- subjects
-- =========================
insert into tblSubjects (SubjectName, CourseId, StaffId) values
('Database Systems', 1, 2),
('Business Management', 2, 2);

-- =========================
-- enrollment
-- =========================
insert into tblEnrollment (StudentId, CourseId, AdmissionDate) values
(1, 1, '2022-07-01'),
(2, 2, '2022-07-01');

-- =========================
-- attendance
-- =========================
insert into tblAttendance (StudentId, SubjectId, AttendanceDate, Status) values
(1, 1, '2023-01-10', 'Present'),
(2, 2, '2023-01-10', 'Absent');

-- =========================
-- exam
-- =========================
insert into tblExam (ExamDate, SubjectId, TotalMarks) values
('2023-03-15', 1, 100),
('2023-03-16', 2, 100);

-- =========================
-- result
-- =========================
insert into tblResult (StudentId, ExamId, MarksObtained, Grade) values
(1, 1, 85, 'A'),
(2, 2, 70, 'B');

-- =========================
-- payment
-- =========================
insert into tblPayment (StudentId, PayTypeId, Amount, PaymentPurposeId, DateOfPayment, Description) values
(1, 2, 15000, 1, '2022-07-02', 'Admission Fee paid via UPI'),
(2, 1, 500, 2, '2023-03-10', 'Exam Fee paid in cash');

-

-- ========================================================================================================
-- testing tables
-- ========================================================================================================

-- lookup tables
select * from tblGender;
select * from tblDesignation;
select * from tblDepartment;
select * from tblAddress;
select * from tblBank;
select * from tblPhotos;
select * from tblCV;

-- staff and related
select * from tblStaff;
select * from tblHOD;

-- academic structure
select * from tblCourse;
select * from tblStudents;
select * from tblSubjects;
select * from tblEnrollment;
select * from tblAttendance;
select * from tblExam;
select * from tblResult;

-- payments
select * from tblPaymentPurpose;
select * from tblPaymentType;
select * from tblPayment;


-- ========================================================================================================
-- testing with joinnings
-- ========================================================================================================

-- list students with their course and department
select s.StudentName, c.CourseName, d.DepartmentName
from tblStudents s
join tblEnrollment e on s.StudentId = e.StudentId
join tblCourse c on e.CourseId = c.CourseId
join tblDepartment d on c.DepartmentId = d.DepartmentId;

-- list staff with designation and department
select st.StaffName, dg.DesignationName, dp.DepartmentName
from tblStaff st
join tblDesignation dg on st.DesignationId = dg.DesignationId
join tblDepartment dp on st.DepartmentId = dp.DepartmentId;

-- list payments with student and purpose
select p.PaymentId, s.StudentName, pt.PayType, pp.PaymentPurpose, p.Amount, p.DateOfPayment
from tblPayment p
join tblStudents s on p.StudentId = s.StudentId
join tblPaymentType pt on p.PayTypeId = pt.PayTypeId
join tblPaymentPurpose pp on p.PaymentPurposeId = pp.PaymentPurposeId;

--Student Full Profile (with course, department, address, gender, photo)

select 
    s.StudentId,
    s.StudentName,
    g.GenderName,
    a.Village,
    a.Post,
    a.Pin,
    c.CourseName,
    d.DepartmentName,
    p.PhotoId
from tblStudents s
join tblGender g on s.GenderId = g.GenderId
join tblAddress a on s.AddressId = a.AddressId
join tblEnrollment e on s.StudentId = e.StudentId
join tblCourse c on e.CourseId = c.CourseId
join tblDepartment d on c.DepartmentId = d.DepartmentId
join tblPhotos p on s.PhotoId = p.PhotoId;

-- Staff Full Profile (with designation, department, bank, address, photo, CV)

select 
    st.StaffId,
    st.StaffName,
    st.Email,
    st.DateOfJoinning,
    st.Salary,
    g.GenderName,
    dg.DesignationName,
    dp.DepartmentName,
    b.BankName,
    b.BranchName,
    a.Village,
    a.Post,
    ph.PhotoId,
    cv.CVId
from tblStaff st
join tblGender g on st.GenderId = g.GenderId
join tblDesignation dg on st.DesignationId = dg.DesignationId
join tblDepartment dp on st.DepartmentId = dp.DepartmentId
join tblBank b on st.BankId = b.BankId
join tblAddress a on st.AddressId = a.AddressId
join tblPhotos ph on st.PhotoId = ph.PhotoId
join tblCV cv on st.CVId = cv.CVId;


--Student Exam Results (with subject, course, department)

select 
    s.StudentName,
    c.CourseName,
    d.DepartmentName,
    sub.SubjectName,
    e.ExamDate,
    r.MarksObtained,
    r.Grade
from tblResult r
join tblStudents s on r.StudentId = s.StudentId
join tblExam e on r.ExamId = e.ExamId
join tblSubjects sub on e.SubjectId = sub.SubjectId
join tblCourse c on sub.CourseId = c.CourseId
join tblDepartment d on c.DepartmentId = d.DepartmentId;

-- Student Payments (with purpose and type)
select 
    s.StudentName,
    pt.PayType,
    pp.PaymentPurpose,
    p.Amount,
    p.DateOfPayment,
    p.Description
from tblPayment p
join tblStudents s on p.StudentId = s.StudentId
join tblPaymentType pt on p.PayTypeId = pt.PayTypeId
join tblPaymentPurpose pp on p.PaymentPurposeId = pp.PaymentPurposeId;


-- Attendance Report (student, subject, course, department)

select 
    s.StudentName,
    sub.SubjectName,
    c.CourseName,
    d.DepartmentName,
    a.AttendanceDate,
    a.Status
from tblAttendance a
join tblStudents s on a.StudentId = s.StudentId
join tblSubjects sub on a.SubjectId = sub.SubjectId
join tblCourse c on sub.CourseId = c.CourseId
join tblDepartment d on c.DepartmentId = d.DepartmentId;



-- ========================================================================================================
-- Store procedures for insert indevidually
-- ========================================================================================================


-- =========================
-- Level 1: Lookup Tables
-- =========================

-- Procedure for tblGender
create procedure spInsertGender
    @GenderName varchar(max)
    as
    begin
        insert into tblGender (GenderName)
       values (@GenderName);

       select scope_identity() as GenderId;
    end


-- Procedure for tblDesignation
create procedure spInsertDesignation
      @DesignationName varchar(max)
    as
    begin
       insert into tblDesignation (DesignationName)
       values (@DesignationName);

        select scope_identity() as DesignationId;
    end


-- Procedure for tblDepartment
create procedure spInsertDepartment
    @DepartmentName varchar(max)
as
begin
    insert into tblDepartment (DepartmentName)
    values (@DepartmentName);

    select scope_identity() as DepartmentId;
end


-- Procedure for tblPaymentPurpose
create procedure spInsertPaymentPurpose
    @PaymentPurpose varchar(max)
as
begin
    insert into tblPaymentPurpose (PaymentPurpose)
    values (@PaymentPurpose);

    select scope_identity() as PaymentPurposeId;
end


-- Procedure for tblPaymentType
create procedure spInsertPaymentType
    @PayType varchar(max)
as
begin
    insert into tblPaymentType (PayType)
    values (@PayType);

    select scope_identity() as PayTypeId;
end


-- =========================
-- Level 2: Supporting Entities
-- =========================

-- Procedure for tblBank
create procedure spInsertBank
    @BankName varchar(max)=null,
    @BranchName varchar(max)=null,
    @IFSC varchar(max)=null,
    @AccountNumber varchar(max)=null
as
begin
    insert into tblBank (BankName, BranchName, IFSC, AccountNumber)
    values (@BankName, @BranchName, @IFSC, @AccountNumber);

    select scope_identity() as BankId;
end

-- 'ddd','dd','dd','123','1233','21333','224442','g@gmail.com'
--@GurdianPhone

exec sp_helptext spInsertAddress
-- Procedure for tblAddress
create procedure spInsertAddress 
    @CareOf varchar(max) = null,
    @Village varchar(max) = null,
    @Post varchar(max) = null,
    @Pin varchar(max) = null,
    @Aadhaar varchar(max) = null,
    @PhoneNumber varchar(max) = null,
    @GuardianPhone varchar(max) = null,
    @GuardianEmail varchar(max) = null
as
begin
    insert into tblAddress (CareOf, Village, Post, Pin, Aadhaar, PhoneNumber,GuardianPhone ,GuardianEmail )
    values (@CareOf, @Village, @Post, @Pin, @Aadhaar, @PhoneNumber, @GuardianPhone, @GuardianEmail);

    select scope_identity() as AddressId;
end



-- Procedure for tblPhotos
create procedure spInsertPhoto
    @Photo varbinary(max)=null
as
begin
    insert into tblPhotos (Photo)
    values (@Photo);

    select scope_identity() as PhotoId;
end

select * from tblPhotos

-- Procedure for tblCV
create procedure spInsertCV
    @CV varbinary(max)=null
as
begin
    insert into tblCV (CV)
    values (@CV);

    select scope_identity() as CVId;
end


-- =========================
-- Level 3: Core Academic Entities
-- =========================

-- Procedure for tblCourse
create procedure spInsertCourse
    @CourseName varchar(max),
    @Duration varchar(max),
    @DepartmentId int
as
begin
    insert into tblCourse (CourseName, Duration, DepartmentId)
    values (@CourseName, @Duration, @DepartmentId);

    select scope_identity() as CourseId;
end


-- Procedure for tblStaff
create procedure spInsertStaff
    @StaffName varchar(max),
    @Email varchar(max) = null,
    @DateOfJoinning date = null,
    @Salary float = null,
    @BloodGroup varchar(10) = null,
    @GenderId int,
    @DesignationId int,
    @BankId int,
    @AddressId int,
    @DepartmentId int,
    @PhotoId int,
    @CVId int
as
begin
    insert into tblStaff (
        StaffName, Email, DateOfJoinning, Salary, BloodGroup,
        GenderId, DesignationId, BankId, AddressId, DepartmentId, PhotoId, CVId
    )
    values (
        @StaffName, @Email, @DateOfJoinning, @Salary, @BloodGroup,
        @GenderId, @DesignationId, @BankId, @AddressId, @DepartmentId, @PhotoId, @CVId
    );

    select scope_identity() as StaffId;
end


-- Procedure for tblStudents
create procedure spInsertStudent
    @StudentName varchar(max),
    @DateOfBirth date = null,
    @GenderId int,
    @Email varchar(max) = null,
    @Phone varchar(max) = null,
    @AddressId int,
    @PhotoId int,
    @BloodGroup varchar (max)=null
as
begin
    insert into tblStudents (
        StudentName, DateOfBirth, GenderId, Email, Phone, AddressId, PhotoId, BloodGroup
    )
    values (
        @StudentName, @DateOfBirth, @GenderId, @Email, @Phone, @AddressId, @PhotoId, @BloodGroup
    );

    select scope_identity() as StudentId;
end


-- =========================
-- Level 4: Relational Entities
-- =========================

-- Procedure for tblSubjects
create procedure spInsertSubject
    @SubjectName varchar(max),
    @CourseId int,
    @StaffId int
as
begin
    insert into tblSubjects (SubjectName, CourseId, StaffId)
    values (@SubjectName, @CourseId, @StaffId);

    select scope_identity() as SubjectId;
end


-- Procedure for tblEnrollment
create procedure spInsertEnrollment
    @StudentId int,
    @CourseId int,
    @AdmissionDate date
as
begin
    insert into tblEnrollment (StudentId, CourseId, AdmissionDate)
    values (@StudentId, @CourseId, @AdmissionDate);

    select scope_identity() as EnrollmentId;
end


-- Procedure for tblAttendance
create procedure spInsertAttendance
    @StudentId int,
    @SubjectId int,
    @AttendanceDate date,
    @Status varchar(max)
as
begin
    insert into tblAttendance (StudentId, SubjectId, AttendanceDate, Status)
    values (@StudentId, @SubjectId, @AttendanceDate, @Status);

    select scope_identity() as AttendanceId;
end


-- Procedure for tblExam
create procedure spInsertExam
    @ExamDate date,
    @SubjectId int,
    @TotalMarks int
as
begin
    insert into tblExam (ExamDate, SubjectId, TotalMarks)
    values (@ExamDate, @SubjectId, @TotalMarks);

    select scope_identity() as ExamId;
end


-- Procedure for tblResult
create procedure spInsertResult
    @StudentId int,
    @ExamId int,
    @MarksObtained int,
    @Grade varchar(max)
as
begin
    insert into tblResult (StudentId, ExamId, MarksObtained, Grade)
    values (@StudentId, @ExamId, @MarksObtained, @Grade);

    select scope_identity() as ResultId;
end


-- =========================
-- Level 5: Financial Transactions
-- =========================

-- Procedure for tblPayment
create procedure spInsertPayment
    @StudentId int,
    @PayTypeId int,
    @Amount bigint,
    @PaymentPurposeId int,
    @DateOfPayment date,
    @Description varchar(max) = null
as
begin
    insert into tblPayment (
        StudentId, PayTypeId, Amount, PaymentPurposeId, DateOfPayment, Description
    )
    values (
        @StudentId, @PayTypeId, @Amount, @PaymentPurposeId, @DateOfPayment, @Description
    );

    select scope_identity() as PaymentId;
end


-- ========================================================================================================
-- Store procedures for get data
-- ========================================================================================================

-- 1. Get Student Full Profile
-- Procedure for retrieving student profile with course, department, gender, address, photo
create procedure spGetStudentProfile
    @StudentId int
as
begin
    select 
        s.StudentId,
        s.StudentName,
        s.DateOfBirth,
        g.GenderName,
        s.Email,
        s.Phone,
        a.Village,
        a.Post,
        a.Pin,
        c.CourseName,
        d.DepartmentName,
        p.PhotoId
    from tblStudents s
    join tblGender g on s.GenderId = g.GenderId
    join tblAddress a on s.AddressId = a.AddressId
    join tblEnrollment e on s.StudentId = e.StudentId
    join tblCourse c on e.CourseId = c.CourseId
    join tblDepartment d on c.DepartmentId = d.DepartmentId
    join tblPhotos p on s.PhotoId = p.PhotoId
    where s.StudentId = @StudentId;
end;
go

-- 2. Get Staff Full Profile
-- SP for retrieving staff profile with designation, department, bank, address, photo, CV
create procedure spGetStaffProfile
    @StaffId int
as
begin
    select 
        st.StaffId,
        st.StaffName,
        st.Email,
        st.DateOfJoinning,
        st.Salary,
        st.BloodGroup,
        g.GenderName,
        dg.DesignationName,
        dp.DepartmentName,
        b.BankName,
        b.BranchName,
        a.Village,
        a.Post,
        ph.PhotoId,
        cv.CVId
    from tblStaff st
    join tblGender g on st.GenderId = g.GenderId
    join tblDesignation dg on st.DesignationId = dg.DesignationId
    join tblDepartment dp on st.DepartmentId = dp.DepartmentId
    join tblBank b on st.BankId = b.BankId
    join tblAddress a on st.AddressId = a.AddressId
    join tblPhotos ph on st.PhotoId = ph.PhotoId
    join tblCV cv on st.CVId = cv.CVId
    where st.StaffId = @StaffId;
end;
go


-- 3. Get Student Exam Results
-- Procedure for retrieving student exam results with subject, course, department
create procedure spGetStudentResults
    @StudentId int
as
begin
    select 
        s.StudentName,
        c.CourseName,
        d.DepartmentName,
        sub.SubjectName,
        e.ExamDate,
        r.MarksObtained,
        r.Grade
    from tblResult r
    join tblStudents s on r.StudentId = s.StudentId
    join tblExam e on r.ExamId = e.ExamId
    join tblSubjects sub on e.SubjectId = sub.SubjectId
    join tblCourse c on sub.CourseId = c.CourseId
    join tblDepartment d on c.DepartmentId = d.DepartmentId
    where s.StudentId = @StudentId;
end;
go

-- 4. Get Student Payments
-- Procedure for retrieving student payments with purpose and type
create procedure spGetStudentPayments
    @StudentId int
as
begin
    select 
        s.StudentName,
        pt.PayType,
        pp.PaymentPurpose,
        p.Amount,
        p.DateOfPayment,
        p.Description
    from tblPayment p
    join tblStudents s on p.StudentId = s.StudentId
    join tblPaymentType pt on p.PayTypeId = pt.PayTypeId
    join tblPaymentPurpose pp on p.PaymentPurposeId = pp.PaymentPurposeId
    where s.StudentId = @StudentId;
end;
go


-- 5. Get Student Attendance
-- Procedure for retrieving student attendance with subject, course, department
create procedure spGetStudentAttendance
    @StudentId int
as
begin
    select 
        s.StudentName,
        sub.SubjectName,
        c.CourseName,
        d.DepartmentName,
        a.AttendanceDate,
        a.Status
    from tblAttendance a
    join tblStudents s on a.StudentId = s.StudentId
    join tblSubjects sub on a.SubjectId = sub.SubjectId
    join tblCourse c on sub.CourseId = c.CourseId
    join tblDepartment d on c.DepartmentId = d.DepartmentId
    where s.StudentId = @StudentId;
end;
go



--Search Student
-- Procedure for searching students by ID or Name
create procedure spGetStudentFullInfo 
    
    @StudentName varchar(max) = null
as
begin
    select 
        s.StudentId,
        s.StudentName,
        s.DateOfBirth,
        g.GenderName,
        s.Email,
        s.Phone,
        a.CareOf,
        a.Village,
        a.Post,
        a.Pin,
        a.Aadhaar,
        a.PhoneNumber,
        p.PhotoId,
        c.CourseName,
        c.Duration,
        d.DepartmentName,
        e.AdmissionDate
    from tblStudents s
    join tblGender g on s.GenderId = g.GenderId
    join tblAddress a on s.AddressId = a.AddressId
    join tblPhotos p on s.PhotoId = p.PhotoId
    join tblEnrollment e on s.StudentId = e.StudentId
    join tblCourse c on e.CourseId = c.CourseId
    join tblDepartment d on c.DepartmentId = d.DepartmentId
    where (@StudentName is null or s.StudentName like '%' + @StudentName + '%');
end;
go

exec sp_helptext spGetStudentFullInfo
--Get Full Staff Information
-- Procedure for retrieving full staff info with all related details
create procedure spGetStaffFullInfo 
    @StaffId int = null,
    @StaffName varchar(max) = null
as
begin
    select 
        st.StaffId,
        st.StaffName,
        st.Email,
        st.DateOfJoinning,
        st.Salary,
        st.BloodGroup,
        g.GenderName,
        dg.DesignationName,
        dp.DepartmentName,
        b.BankName,
        b.BranchName,
        b.IFSC,
        b.AccountNumber,
        a.CareOf,
        a.Village,
        a.Post,
        a.Pin,
        a.Aadhaar,
        a.PhoneNumber,
        ph.PhotoId,
        cv.CVId
    from tblStaff st
    join tblGender g on st.GenderId = g.GenderId
    join tblDesignation dg on st.DesignationId = dg.DesignationId
    join tblDepartment dp on st.DepartmentId = dp.DepartmentId
    join tblBank b on st.BankId = b.BankId
    join tblAddress a on st.AddressId = a.AddressId
    join tblPhotos ph on st.PhotoId = ph.PhotoId
    join tblCV cv on st.CVId = cv.CVId
    where (@StaffId is null or st.StaffId = @StaffId)
      and (@StaffName is null or st.StaffName like '%' + @StaffName + '%');
end;
go


-- test searches
exec spGetStudentFullInfo @StudentId = 1;
exec spGetStudentFullInfo @StudentName = 'Rahul';

exec spGetStaffFullInfo @StaffId = 2;
exec spGetStaffFullInfo @StaffName = 'Banerjee';
--


-- Get Gender, Get Designation, Get Department, get Hod, get course, get subject, get PaymentPurpose, get PaymentType 


-- =========================
-- Get Gender (tblGender)
-- =========================
create procedure spGetGender
as
begin
    select GenderId, GenderName
    from tblGender;
end
go

-- =========================
-- Get Designation (tblDesignation)
-- =========================
create procedure spGetDesignation
as
begin
    select DesignationId, DesignationName
    from tblDesignation;
end;
go

-- =========================
-- Get Department (tblDepartment)
-- =========================
create procedure spGetDepartment
as
begin
    select DepartmentId, DepartmentName
    from tblDepartment;
end;
go

-- =========================
-- Get HOD (tblHOD with joins)
-- =========================
create procedure spGetHOD
as
begin
    select 
        h.HODId,
        st.StaffName,
        d.DepartmentName
    from tblHOD h
    join tblStaff st on h.StaffId = st.StaffId
    join tblDepartment d on h.DepartmentId = d.DepartmentId;
end;
go

-- =========================
-- Get Course (tblCourse with department)
-- =========================
create procedure spGetCourse
as
begin
    select 
        c.CourseId,
        c.CourseName,
        c.Duration,
        d.DepartmentName
    from tblCourse c
    join tblDepartment d on c.DepartmentId = d.DepartmentId;
end


-- =========================
-- Get Subject (tblSubjects with course + staff)
-- =========================
create procedure spGetSubject
as
begin
    select 
        sub.SubjectId,
        sub.SubjectName,
        c.CourseName,
        st.StaffName
    from tblSubjects sub
    join tblCourse c on sub.CourseId = c.CourseId
    join tblStaff st on sub.StaffId = st.StaffId;
end;
go

-- =========================
-- Get PaymentPurpose (tblPaymentPurpose)
-- =========================
create procedure spGetPaymentPurpose
as
begin
    select PaymentPurposeId, PaymentPurpose
    from tblPaymentPurpose;
end


-- =========================
-- Get PaymentType (tblPaymentType)
-- =========================
create procedure spGetPaymentType
as
begin
    select PayTypeId, PayType
    from tblPaymentType;
end

-- Procedure for total students
create procedure spTotalStudents
as
begin
    select count(*) as TotalStudents
    from tblStudents;
end

-- Procedure for total staff
create procedure spTotalStaff
as
begin
    select count(*) as TotalStaff
    from tblStaff;
end


-- Procedure for total subjects
create procedure spGetTotalSubjects
as
begin
    select count(*) as TotalSubjects
    from tblSubjects;
end

-- Procedure for total courses
create procedure spTotalCourses
as
begin
    select count(*) as TotalCourses
    from tblCourse;
end;
go

-- Procedure to get the maximum StudentId
create procedure spGetMaxStudentId
as
begin
    select max(StudentId) as MaxStudentId
    from tblStudents;
end


-- Procedure to get GenderId by GenderName
create procedure spGetGenderID
    @GenderName varchar(max)
as
begin
    select GenderId
    from tblGender
    where GenderName = @GenderName;
end

-- Procedure to get DesignationId by DesignationName
create procedure spGetDesignationID
    @DesignationName varchar(max)
as
begin
    select DesignationId
    from tblDesignation
    where DesignationName = @DesignationName;
end

-- Procedure to get the maximum StaffId
create procedure spGetMaxStaffId
as
begin
    select max(StaffId) as MaxStaffId
    from tblStaff;
end

-- Procedure to get DepartmentId by DepartmentName
create procedure spGetDepartmentID 
    @DepartmentName varchar(max)
as
begin
    select DepartmentId 
    from tblDepartment
    where DepartmentName = @DepartmentName;
end

select * from tblDepartment


-- =============================================================================
-- HOD

-- Procedure to assign or update HOD for a department
create procedure spUpdateHOD
    @DepartmentId int,
    @StaffId int
as
begin
    -- If HOD already exists for the department, update it
    if exists (select 1 from tblHOD where DepartmentId = @DepartmentId)
    begin
        update tblHOD
        set StaffId = @StaffId
        where DepartmentId = @DepartmentId;
    end
    else
    begin
        -- Otherwise insert new HOD record
        insert into tblHOD (DepartmentId, StaffId)
        values (@DepartmentId, @StaffId);
    end

    select scope_identity() as HODId;
    -- Return the current HOD info
    --select h.HODId, d.DepartmentName, s.StaffName
    --from tblHOD h
    --join tblDepartment d on h.DepartmentId = d.DepartmentId
    --join tblStaff s on h.StaffId = s.StaffId
    --where h.DepartmentId = @DepartmentId;
end

select * from tblStaff
-- ===============================================================================


-- Procedure to get full information of all staff

create procedure spGetAllStaffInformation
as
begin
    select 
        st.StaffId,
        st.StaffName,
        st.Email,
        st.DateOfJoinning,
        st.Salary,
        st.BloodGroup,
        g.GenderName,
        dg.DesignationName,
        dp.DepartmentName,
        b.BankName,
        b.BranchName,
        b.IFSC,
        b.AccountNumber,
        a.CareOf,
        a.Village,
        a.Post,
        a.Pin,
        a.Aadhaar,
        a.PhoneNumber,
        ph.Photo,   -- binary photo data
        cv.CV       -- binary CV data
    from tblStaff st
    join tblGender g on st.GenderId = g.GenderId
    join tblDesignation dg on st.DesignationId = dg.DesignationId
    join tblDepartment dp on st.DepartmentId = dp.DepartmentId
    join tblBank b on st.BankId = b.BankId
    join tblAddress a on st.AddressId = a.AddressId
    join tblPhotos ph on st.PhotoId = ph.PhotoId
    join tblCV cv on st.CVId = cv.CVId
    order by st.StaffName;
end;
go





-- Procedure to get full information of all students
create procedure spGetAllStudentInformation
as
begin
    select 
        s.StudentId,
        s.StudentName,
        s.DateOfBirth,
        g.GenderName,
        s.Email,
        s.Phone,
        a.CareOf,
        a.Village,
        a.Post,
        a.Pin,
        a.Aadhaar,
        a.PhoneNumber,
        c.CourseName,
        c.Duration,
        d.DepartmentName,
        e.AdmissionDate
        
        
    from tblStudents s
    join tblGender g on s.GenderId = g.GenderId
    join tblAddress a on s.AddressId = a.AddressId
    join tblEnrollment e on s.StudentId = e.StudentId
    join tblCourse c on e.CourseId = c.CourseId
    join tblDepartment d on c.DepartmentId = d.DepartmentId
    
    order by s.StudentName;
end

--================================================================================================================================
-- New StoreProcedures For Update 06/07/2026

create procedure spUpdateStaffInfo 
    @StaffId int,
    @StaffName varchar(100),
    @Email varchar(100),
    @DateOfJoinning date,
    @Salary decimal(10,2),
    @BloodGroup varchar(10),
    @GenderId int,
    @DesignationId int,
    @DepartmentId int
as
begin
    update tblStaff
    set StaffName = @StaffName,
        Email = @Email,
        DateOfJoinning = @DateOfJoinning,
        Salary = @Salary,
        BloodGroup = @BloodGroup,
        GenderId = @GenderId,
        DesignationId = @DesignationId,
        DepartmentId = @DepartmentId

    where StaffId = @StaffId;
end

--update Bank
-- Procedure to update Bank information
create procedure spUpdateBank
    @BankId int,
    @BankName varchar(max),
    @BranchName varchar(max),
    @IFSC varchar(Max),
    @AccountNumber varchar(Max)
as
begin
    update tblBank
    set BankName = @BankName,
        BranchName = @BranchName,
        IFSC = @IFSC,
        AccountNumber = @AccountNumber
    where BankId = @BankId;
end

-- Procedure to update Address information
create procedure spUpdateAddress
    @AddressId int,
    @CareOf varchar(max)=null,
    @Village varchar(max)=null,
    @Post varchar(max)=null,
    @Pin varchar(max)=null,
    @Aadhaar varchar(max)=null,
    @PhoneNumber varchar(max)=null,
    @GuardianPhone varchar (max)=null,
    @GuardianEmail varchar (max)= null

as
begin
    update tblAddress
    set CareOf = @CareOf,
        Village = @Village,
        Post = @Post,
        Pin = @Pin,
        Aadhaar = @Aadhaar,
        PhoneNumber = @PhoneNumber,
        GuardianPhone = @GuardianPhone,
        GuardianEmail = @GuardianEmail
    where AddressId = @AddressId;
end


-- Procedure to update Photo binary data
create procedure spUpdatePhoto
    @PhotoId int,
    @PhotoData varbinary(max)
as
begin
    update tblPhotos
    set Photo = @PhotoData
    where PhotoId = @PhotoId;
end


-- Procedure to update only CV binary data
create procedure spUpdateCV
    @CVId int,
    @CV varbinary(max)
as
begin
    update tblCV
    set CV = @CV
    where CVId = @CVId;
end



-- Procedure to search Staff by name and return Id, Name, Department
create procedure spSearchStaffBasic 
    @StaffName varchar(max)
as
begin
    select 
        st.StaffId,
        st.StaffName,
        dp.DepartmentName
    from tblStaff st
    join tblDepartment dp on st.DepartmentId = dp.DepartmentId
    where st.StaffName like '%' + @StaffName + '%'
    order by st.StaffName;
end

select * from tblStaff


-- Procedure to search Staff by StaffId and return full info including Photo and CV binary
create procedure spGetFullInfoByStaffId 
    @StaffId int
as
begin
    select 
        st.StaffId,
        st.StaffName,
        st.Email,
        st.DateOfJoinning,
        st.Salary,
        st.BloodGroup,
        g.GenderName,
        dg.DesignationName,
        dp.DepartmentName,
        b.BankName,
        b.BranchName,
        b.IFSC,
        b.AccountNumber,
        a.CareOf,
        a.Village,
        a.Post,
        a.Pin,
        a.Aadhaar,
        a.PhoneNumber,

        ph.Photo,   
        cv.CV
    from tblStaff st
    join tblGender g on st.GenderId = g.GenderId
    join tblDesignation dg on st.DesignationId = dg.DesignationId
    join tblDepartment dp on st.DepartmentId = dp.DepartmentId
    join tblBank b on st.BankId = b.BankId
    join tblAddress a on st.AddressId = a.AddressId
    join tblPhotos ph on st.PhotoId = ph.PhotoId
    join tblCV cv on st.CVId = cv.CVId
    where st.StaffId = @StaffId 
    
end



select * from tblStaff


-- Procedure to get AddressId, BankId, PhotoId, CVId by StaffId
create procedure spGetStaffLinkedIds 
    @StaffId int
as
begin
    select 
        st.StaffId,
        st.AddressId,
        st.BankId,
        st.PhotoId,
        st.CVId
    from tblStaff st
    where st.StaffId = @StaffId;
end

-- Procedure to get all Blood Groups
create procedure spGetBloodGroups
as
begin
    select 
        BloodGroupId,
        BloodGroupName
    from tblBloodGroup
    order by BloodGroupName;
end


-- Procedure to get CourseId by CourseName
create procedure spGetCourseIdByName
    @CourseName varchar(max)
as
begin
    select 
        CourseId,
        CourseName,
        Duration,
        DepartmentId
    from tblCourse
    where CourseName like '%' + @CourseName + '%'
    order by CourseName;
end

-- Procedure to update Student basic information
create procedure spUpdateStudent
    @StudentId int,
    @StudentName varchar(max),
    @DateOfBirth date,
    @GenderId int,
    @Email varchar(max),
    @Phone varchar(max),
    @BloodGroup varchar (max)
as
begin
    update tblStudents
    set StudentName = @StudentName,
        DateOfBirth = @DateOfBirth,
        GenderId = @GenderId,
        Email = @Email,
        Phone = @Phone,
        BloodGroup = @BloodGroup
    where StudentId = @StudentId;
end

-- Procedure to update only CourseId and AdmissionDate in Enrollment
create procedure spUpdateEnrollment
    @EnrollmentId int,
    @CourseId int,
    @AdmissionDate date
as
begin
    update tblEnrollment
    set CourseId = @CourseId,
        AdmissionDate = @AdmissionDate
    where EnrollmentId = @EnrollmentId;
end

-- Procedure to search Student by name and return Id, Name, Enrolled Course, Guardian
create procedure spSearchStudentBesicInfoByName
    @StudentName varchar(max)
as
begin
    select 
        s.StudentId,
        s.StudentName,
        c.CourseName,
        a.CareOf as Guardian
    from tblStudents s
    join tblEnrollment e on s.StudentId = e.StudentId
    join tblCourse c on e.CourseId = c.CourseId
    join tblAddress a on s.AddressId = a.AddressId
    where s.StudentName like '%' + @StudentName + '%'
    order by s.StudentName;
end



-- Procedure to get full Student information by Id (including Photo)
create procedure spGetStudentFullInformationById 6
    @StudentId int
as
begin
    select 
        s.StudentId,
        s.StudentName,
        s.DateOfBirth,
        g.GenderName,
        s.Email,
        s.Phone,
        s.BloodGroup,
        a.CareOf as Guardian,
        a.Village,
        a.Post,
        a.Pin,
        a.Aadhaar,
        a.PhoneNumber, --not in use
        a.GuardianPhone,
        a.GuardianEmail,
        c.CourseName,
        c.Duration,
        d.DepartmentName,
        ph.Photo   -- binary photo data
    from tblStudents s
    join tblGender g on s.GenderId = g.GenderId
    join tblAddress a on s.AddressId = a.AddressId
    join tblEnrollment e on s.StudentId = e.StudentId
    join tblCourse c on e.CourseId = c.CourseId
    join tblDepartment d on c.DepartmentId = d.DepartmentId
    join tblPhotos ph on s.PhotoId = ph.PhotoId
    where s.StudentId = @StudentId;
end


-- Procedure to get Student-related IDs by StudentId
create procedure spGetStudentRelatedIds
    @StudentId int
as
begin
    select 
        s.StudentId,
        s.AddressId,
        s.PhotoId,
        e.EnrollmentId,
        e.CourseId
    from tblStudents s
    left join tblEnrollment e on s.StudentId = e.StudentId
    where s.StudentId = @StudentId;
end
















--========================================================================
-- AIO StudentInsattion create procedure spInsertStudent   (No Need)
    create procedure spInsertStudent
    @StudentName varchar(max),
    @DateOfBirth date = null,
    @GenderId int,
    @Email varchar(max) = null,
    @Phone varchar(max) = null,
    @CareOf varchar(max) = null,
    @Village varchar(max) = null,
    @Post varchar(max) = null,
    @Pin varchar(max) = null,
    @Aadhaar varchar(max) = null,
    @PhoneNumber varchar(max) = null,
    @GuardianPhone varchar(20) = null,
    @GuardianEmail varchar(50) = null,
    @Photo varbinary(max) = null,
    @CourseId int,
    @AdmissionDate date
as
begin
    set nocount on;

    -- Insert Address first
    insert into tblAddress (CareOf, Village, Post, Pin, Aadhaar, PhoneNumber, GuardianPhone, GuardianEmail)
    values (@CareOf, @Village, @Post, @Pin, @Aadhaar, @PhoneNumber, @GuardianPhone, @GuardianEmail);

    declare @AddressId int = scope_identity();

    -- Insert Photo
    insert into tblPhotos (Photo)
    values (@Photo);

    declare @PhotoId int = scope_identity();

    -- Insert Student
    insert into tblStudents (StudentName, DateOfBirth, GenderId, Email, Phone, AddressId, PhotoId)
    values (@StudentName, @DateOfBirth, @GenderId, @Email, @Phone, @AddressId, @PhotoId);

    declare @StudentId int = scope_identity();

    -- Insert Enrollment
    insert into tblEnrollment (StudentId, CourseId, AdmissionDate)
    values (@StudentId, @CourseId, @AdmissionDate);

    -- Return StudentId
    select @StudentId as StudentId;
end
--=====================================================================

 alter proc spGetAllStaffSearchDetailsByName 'd'
 @StaffName varchar(max)
 as
 begin
 select tblStaff.StaffId,tblStaff.StaffName,tblDepartment.DepartmentName 
 from tblStaff join tblDepartment on tblStaff.DepartmentId=tblDepartment.DepartmentId
 where tblStaff.StaffName like '%'+@StaffName+'%'
 end