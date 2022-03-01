INSERT INTO Reservation
(CreationDate, Staff, ClientID)
VALUES ('06/01/2022', 'Doug', 3);

SELECT MAX ReservationID from Reservation as MaxID

insert into [reservation-Room]
values (maxID,1,'12/01/2022',0,'06/01/2022')