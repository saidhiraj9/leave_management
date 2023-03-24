namespace abc.Models
{
    public class LeaveRequest
    {
        public int id { get; set; }
        public int employee_id { get; }
        public int leave_type_id { get;}
        public DateTime leave_start_date { get; set; }
        public DateTime leave_end_date { get; set; }
        public DateTime requested_at { get; set; }


    }
}
