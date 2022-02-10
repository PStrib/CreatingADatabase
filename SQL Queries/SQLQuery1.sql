select roomid, concat(month(startdate),'/',year(startdate)) as StartDate, concat(month(enddate),'/', year(enddate)) as EndDate
        from[reservation-room]
        where month(startdate)>=1
        and year(startdate)=2022
        and roomid=2