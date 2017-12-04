using System;
using System.Collections.Generic;
using System.Text;

namespace ITLec.DesignPattern.Creational.Builder
{
   public class CertificationBuilder: WorkerBuilder
    {

        public CertificationBuilder(Worker worker)
        {
            if (worker.Certification == null)
            {
                worker.Certification = new Certification();
            }
            this.worker = worker;
        }

        public CertificationBuilder Name(string certificationName)
        {
            worker.Certification.CertificationName = certificationName;

            return this;
        }
        public CertificationBuilder Authority(string certificationAuthority)
        {
            worker.Certification.CertificationAuthority = certificationAuthority;

            return this;
        }
        public CertificationBuilder LicenceNumber(string licenceNumber)
        {
            worker.Certification.LicenseNumber = licenceNumber;

            return this;
        }
        public CertificationBuilder From(DateTime  certificationIssueDate)
        {
            worker.Certification.From = certificationIssueDate;

            return this;
        }
    }
}
