UPDATE c
                                    SET c.Pesetas = c.Pesetas + sq.TotalPrice
                                    FROM Customer c
                                    INNER JOIN (SELECT SUM(t.Price) as TotalPrice, t.Customer_Id as Customer_Id
                                          FROM Ticket t
                                          INNER JOIN Concert con ON t.Concert_Id = con.Id
                                          WHERE con.Id = 3
                                          GROUP BY t.Customer_Id) AS sq ON sq.Customer_Id = c.Id
									INNER JOIN Ticket t ON t.Customer_Id = sq.Customer_Id		
                                    INNER JOIN Concert con ON t.Concert_Id = con.Id
                                    WHERE con.Id = 3

										  UPDATE Concert
										  SET IsCanceled = 1
										  WHERE Concert.Id = 1

										  USE Piljetter
										  SELECT * FROM Concert

										  SELECT Pesetas FROM Customer WHERE Id = 1

WITH ReturnedPesetasAndCustomerID (TotalPrice, Customer_Id) AS (
		SELECT SUM(t.Price) as TotalPrice, t.Customer_Id as Customer_Id
        FROM Ticket t
        INNER JOIN Concert con ON t.Concert_Id = con.Id
        WHERE con.Id = 3
        GROUP BY t.Customer_Id
)

UPDATE c
                                    SET c.Pesetas = c.Pesetas + cte.TotalPrice
                                    FROM Customer c
                                    INNER JOIN ReturnedPesetasAndCustomerID cte ON c.Id = cte.Customer_Id
									INNER JOIN Ticket t ON t.Customer_Id = cte.Customer_Id		
                                    INNER JOIN Concert con ON t.Concert_Id = con.Id
                                    WHERE con.Id = 3


                                    DELETE t 
									FROM Ticket t
                                    INNER JOIN (SELECT c.Id AS Concert_Id
                                                FROM Concert c
                                                WHERE c.IsCanceled = 1) as ConIdTable ON t.Concert_Id = ConIdTable.Concert_Id
                                    WHERE t.Concert_Id = ConIdTable.Concert_Id						
									





									SELECT * FROM Ticket

									WITH TicketsAndCustomerId (Tickets, Customer_Id) AS (SELECT Count(*)AS Tickets, t.Customer_Id as Customer_Id
                                          FROM Ticket t
                                          INNER JOIN Concert con ON t.Concert_Id = con.Id
                                          WHERE con.Id = 2
                                          GROUP BY t.Customer_Id)
										  USE Piljetter

									INSERT INTO TicketCoupon (CouponValue, Customer_Id) 
									SELECT tc.Tickets, tc.Customer_Id
									FROM (SELECT Count(*)AS Tickets, t.Customer_Id as Customer_Id
                                          FROM Ticket t
                                          INNER JOIN Concert con ON t.Concert_Id = con.Id
                                          WHERE con.Id = 1
                                          GROUP BY t.Customer_Id) as tc