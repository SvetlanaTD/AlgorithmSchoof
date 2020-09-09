using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace SchoofAlgorithm
{
    public partial class GF
    {
        public class Poly
        {
            private IEnumerable<Term> terms;

            public Poly(IEnumerable<Term> terms)
            {
                this.terms = terms;
            }

            public static Poly operator +(Poly p1, Poly p2)
            {
                List<Term> sumTerms = new List<Term>();
                foreach (Term t1 in p1.terms)
                {
                    Term t2 = p2.terms.Where(t => t.Exponent == t1.Exponent).FirstOrDefault();
                    if (t2 == null)
                        sumTerms.Add(t1);
                    else
                        sumTerms.Add(new Term(t1.Coeff + t2.Coeff, t1.Exponent));
                }

                foreach (Term t2 in p2.terms)
                {                    
                    Term t1 = p2.terms.Where(t => t.Exponent == t2.Exponent).FirstOrDefault();
                    if (t1 == null)
                        sumTerms.Add(t2);
                }

                return new Poly(sumTerms);
            }

            public static Poly operator -(Poly p1, Poly p2)
            {
                List<Term> sumTerms = new List<Term>();
                foreach (Term t1 in p1.terms)
                {
                    Term t2 = p2.terms.Where(t => t.Exponent == t1.Exponent).FirstOrDefault();
                    if (t2 == null)
                        sumTerms.Add(t1);
                    else
                        sumTerms.Add(new Term(t1.Coeff - t2.Coeff, t1.Exponent);
                }

                foreach (Term t2 in p2.terms)
                {                    
                    Term t1 = p2.terms.Where(t => t.Exponent == t2.Exponent).FirstOrDefault();
                    if (t1 == null)
                        sumTerms.Add(t2);
                }

                return new Poly(sumTerms.OrderBy(t => t.Exponent).ToList());
            }

            public static Poly operator *(Poly p1, Poly p2)
            {
                List<Term> mulTerms = new List<Term>();
                foreach(Term t1 in p1.terms)
                    foreach (Term t2 in p2.terms)
                    {
                        mulTerms.Add(new Term(t1.Coeff * t2.Coeff, t1.Exponent + t2.Exponent));
                    }

                mulTerms = mulTerms.OrderBy(t => t.Exponent)
                            .GroupBy(t => t.Exponent)
                            .Select(g => new Term(g.Aggregate((currentSum, t) => currentSum + t.Coeff), g.Key))
                            .ToList();

            }

            public static Poly operator /(Poly p1, Poly p2)
            {
                throw new NotImplementedException();
            }
        }

        public Poly CreatePoly(IEnumerable<Term> terms)
        {
            return new Poly(terms);
        }
    }
}
