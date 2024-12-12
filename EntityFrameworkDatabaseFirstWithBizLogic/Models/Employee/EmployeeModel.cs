using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace EntityFrameworkDatabaseFirstWithBizLogic.Models
{
    public class EmployeeModel
    {
        private readonly NorthwindEntities _northwindEntities;

        public EmployeeModel()
        {
            _northwindEntities = new NorthwindEntities();
        }

        /// <summary>
        /// 取得員工資料
        /// </summary>
        /// <param name="predicate"></param>
        /// <returns></returns>
        public List<Employees> GetEmployees(
            Expression<Func<Employees, bool>> predicate = null
            )
        {
            if (predicate is null)
            {
                return _northwindEntities
                    .Employees
                    .AsNoTracking()
                    .ToList();
            }

            return _northwindEntities
                    .Employees
                    .AsNoTracking()
                    .Where( predicate )
                    .ToList();
        }
    }
}