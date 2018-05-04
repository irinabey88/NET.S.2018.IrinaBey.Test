using System;
using Task1.Solution.Interfaces.Repository;

namespace Task1.Solution.Repository
{
    public class SqlPasswordRepository : IRepository
    {
        private SqlPasswordRepository _repository;

        public SqlPasswordRepository() => this._repository = new SqlPasswordRepository();

        public void Create(string pasword)
        {
            if (string.IsNullOrWhiteSpace(pasword))
            {
                throw new ArgumentNullException(nameof(pasword));
            }

            this._repository.Create(pasword);
        }
    }
}