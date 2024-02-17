<!-- CLASES EN PHP -->
<?php 

class Cliente{
    private $Nombre;
    private $Telefono;
    private $Email;
    
    public function __construct($nombre, $telefono, $email) {
        $this->Nombre = $nombre;
        $this->Telefono = $telefono;
        $this->Email = $email;
    }

    public function getNombre(){
        return $this->Nombre;
    }
    
    public function setNombre($nombre){
        $this->Nombre = $nombre;
    }
    
    public function getTelefono(){
        return $this->Telefono;
    }
    
    public function setTelefono($telefono){
        $this->Telefono = $telefono;
    }
    
    public function getEmail(){
        return $this->Email;
    }
    
    public function setEmail($email){
        $this->Email = $email;
    }
    
    public function toString():void{
        echo "Nombre: " . $this->Nombre . "\n" . "Telefono: " . $this->Telefono . "\n" . "Email: " . $this->Email . "\n";
    }

}

$cliente= new Cliente("Patito",47512,"Patito@gmail");
echo $cliente->toString();
$cliente->setNombre("Kevin");
$cliente->setTelefono(482153);
$cliente->setEmail("Kevin@gmail");
echo $cliente->toString();

//HERENCIA

class Persona{
    private $Nombre;
    private $Telefono;
    private $Email;
    public function getNombre(){
        return $this->Nombre;
    }
    
    public function setNombre($nombre){
        $this->Nombre = $nombre;
    }
    
    public function getTelefono(){
        return $this->Telefono;
    }
    
    public function setTelefono($telefono){
        $this->Telefono = $telefono;
    }
    
    public function getEmail(){
        return $this->Email;
    }
    
    public function setEmail($email){
        $this->Email = $email;
    }
    
    public function toString():void{
        echo "Nombre: " . $this->Nombre . "\n" . "Telefono: " . $this->Telefono . "\n" . "Email: " . $this->Email . "\n";
    }

}

class Estudiante extends Persona{
    private $Registro;
    public function getRegistro(){
        return $this->Registro;
    }
    
    public function setRegistro($Registro){
        $this->Registro = $Registro;
    }
    public function toString():void{
        echo "Nombre: " . $this->getNombre() . "\n" . "Telefono: " . $this->getTelefono() . "\n" . "Email: " . $this->getEmail() . "\n"."Registro: " . $this->Registro;
    }
}
$estudiante=new Estudiante();
$estudiante->setNombre("Kevin");
$estudiante->setTelefono(482153);
$estudiante->setEmail("Kevin@gmail");
$estudiante->setRegistro("Activo");
echo $estudiante->toString();
; ?>