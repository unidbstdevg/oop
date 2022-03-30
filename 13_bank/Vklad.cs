public class Vklad {
    private double proc;
    private double summ;

    public Vklad() {
        summ = 1000;
        proc 0.01;
    }

    public double Summ {
        get {
            return summ;
        }
        set {
            double oldsumm = summ;
            summ = value;
            if (oldsumm < porog && summm >= porog)
                PorogEvent?.Invoke();
        }
    }

    public void NextYear() {
        Summ += Summ * proc / 100;
    }

    public void Income(double val) {
        Summ += val;
    }
    public void Outcome(double val) {
        Summ -= val;
    }
}
