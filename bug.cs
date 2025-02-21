public class MyClass {
    public int MyProperty { get; set; }

    public void MyMethod() {
        // This line will cause a NullReferenceException if MyProperty is not initialized.
        int value = MyProperty * 2; 
    }
}