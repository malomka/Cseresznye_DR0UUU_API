function Load() {
    fetch("api/tag", {
        method: 'GET',
        headers: {
            'Content-Type':'application/json'
        }
    }).then(response => {
        if (!response.ok) {
            throw new Error("hálózati hiba", response.statusText)
        }
        return response.json();
    }).then(data => {
        Feltoltes(data);
    }).catch(error => {
        console.error("fetch hiba", error)
    })
}

Load();

function Feltoltes(adat) {
    var tabla = document.getElementById("tag_tablazat");
    for (var i = 0; i < adat.length; i++) {
        var sor = adat[i];
        var sorhtml = document.createElement("tr");
        for (var j in sor) {
            var oszlophtml = document.createElement("td");
            oszlophtml.textContent = sor[j];

            sorhtml.appendChild(oszlophtml);
        }
        tabla.appendChild(sorhtml);
    }
}

document.getElementById("addButton").addEventListener("click", () => {
    let nev = document.getElementById("tagnev").value;
    let email = document.getElementById("emailcim").value;
    let telefonszam = document.getElementById("telefonszam").value;
    let tagsagiszam = document.getElementById("tagsagiszam").value;

    fetch(`api/tag/ujTag/${nev}/${email}/${telefonszam}/${tagsagiszam}`, {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        }
    }).then(response => {
        if (response.ok) {
            alert("sikeres hozzáadás");
        }
        else {
            alert("sikertelen hozzáadás");
        }
    })
});