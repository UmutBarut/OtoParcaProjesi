using OtoYedekParca.Core.Utilities.Results;
using OtoYedekParca.Entity;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OtoYedekParca.Business.Abstracts
{
    public interface IFileService
    {
       Task<IResult> AddForMarka(IFormFile dosya, Marka marka);
    }
}