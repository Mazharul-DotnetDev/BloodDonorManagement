using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication9.Models
{
    public class DonorRepository
    {

        static Dictionary<int, Donor> info = new Dictionary<int, Donor>();

        public DonorRepository()
        {
            if (info.Count == 0)
            {
                for (int i = 1; i <= 5; i++)
                {
                    info.Add(i, new Donor()
                    {
                        DonorId = i,
                        FirstName = "A" + i,
                        LastName = "B" + i,
                        BloodGroup = "A"+ "B" + "O" + i
                    });
                     
                }
            }
        }


        public List<Donor> DonorList
        {
            get
            {
                return info.Values.ToList();
            }
        }

        public Donor GetById (int DonorId)
        {
            return info [DonorId];

        }

        public void Save (Donor d)
        {
            d.DonorId = info.Count + 1;
            info.Add(d.DonorId, d);

        }

        public void Update (Donor d)
        {
            info [d.DonorId] = d;

        }

        public void Delete(int DonorId)
        {
            info.Remove(DonorId);

        }
    }
}